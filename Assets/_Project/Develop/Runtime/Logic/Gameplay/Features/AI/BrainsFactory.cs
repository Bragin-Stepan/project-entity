using System;
using System.Collections.Generic;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Timer;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI
{
    public class BrainsFactory
    {
        private readonly DIContainer _container;

        private readonly EntitiesLifeContext _entitiesLifeContext;
        private readonly AIBrainsContext _aiBrainsContext;
        private readonly TimerServiceFactory _timerServiceFactory;
        private readonly IPlayerInput _playerInput;
        
        public BrainsFactory(DIContainer container)
        {
            _container = container;
            
            _playerInput = _container.Resolve<IPlayerInput>();
            _aiBrainsContext = _container.Resolve<AIBrainsContext>();
            _timerServiceFactory = _container.Resolve<TimerServiceFactory>();
            _entitiesLifeContext = _container.Resolve<EntitiesLifeContext>();
        }

        public StateMachineBrain CreateGhostBrain(Entity entity)
        {
            AIStateMachine stateMachine = CreateRandomMovementStateMachine(entity);
            StateMachineBrain brain = new (stateMachine);
            
            _aiBrainsContext.SetFor(entity, brain);

            return brain;
        }
        
        public StateMachineBrain CreateMainHeroBrain(Entity entity, ITargetSelector targetSelector)
        {
            AIStateMachine combatState = CreateAutoAttackStateMachine(entity);
            PlayerInputMovementState movementState = new (entity, _playerInput);

            ReactiveVariable<Entity> currentTarget = entity.CurrentTarget;

            ICompositeCondition fromMovementToCombatStateCondition = new CompositeCondition()
                .Add(new FuncCondition(() => currentTarget.Value != null))
                .Add(new FuncCondition(() => _playerInput.Move.Value == Vector2.zero));
            
            ICompositeCondition fromCombatToMovementStateCondition = new CompositeCondition(LogicOperationsUtils.Or)
                .Add(new FuncCondition(() => currentTarget.Value == null))
                .Add(new FuncCondition(() => _playerInput.Move.Value != Vector2.zero));

            AIStateMachine behaviour = new ();
            
            behaviour.AddState(combatState);
            behaviour.AddState(movementState);
            
            behaviour.AddTransition(combatState, movementState, fromCombatToMovementStateCondition);
            behaviour.AddTransition(movementState, combatState, fromMovementToCombatStateCondition);

            FindTargetState findTargetState = new (_entitiesLifeContext, entity, targetSelector);
            AIParallelState parallelState = new (findTargetState, behaviour);

            AIStateMachine rootStateMachine = new ();
            
            rootStateMachine.AddState(parallelState);
            
            StateMachineBrain brain = new (rootStateMachine);
            
            _aiBrainsContext.SetFor(entity, brain);

            return brain;
        }

        private AIStateMachine CreateRandomMovementStateMachine(Entity entity)
        {
            List<IDisposable> disposables = new ();
            
            RandomMovementState randomMovementState = new (entity, 0.5f);
            EmptyState emptyState = new ();

            TimerService movementTimer = _timerServiceFactory.Create(2f);
            disposables.Add(randomMovementState.Entered.Subscribe(movementTimer.Restart));
            disposables.Add(movementTimer);
            
            TimerService idleTimer = _timerServiceFactory.Create(3f);
            disposables.Add(emptyState.Entered.Subscribe(idleTimer.Restart));
            disposables.Add(idleTimer);
            
            FuncCondition movementTimerEndedCondition = new (() => movementTimer.IsOver);
            FuncCondition idleTimerEndedCondition = new (() => idleTimer.IsOver);
            
            AIStateMachine stateMachine = new (disposables);
            
            stateMachine.AddState(randomMovementState);
            stateMachine.AddState(emptyState);
            
            stateMachine.AddTransition(randomMovementState, emptyState, movementTimerEndedCondition);
            stateMachine.AddTransition(emptyState, randomMovementState, idleTimerEndedCondition);
            
            return stateMachine;
        }

        private AIStateMachine CreateAutoAttackStateMachine(Entity entity)
        {
            RotateToTargetState rotateToTargetState = new (entity);
            AttackTriggerState attackTriggerState = new (entity);
        
            ICondition canAttack = entity.CanStartAttack;
            Transform transform = entity.Transform;
            ReactiveVariable<Entity> currentTarget = entity.CurrentTarget;

            ICompositeCondition fromRotateToAttackCondition = new CompositeCondition()
                .Add(canAttack)
                .Add(new FuncCondition(() =>
                    {
                        Entity target = currentTarget.Value;

                        if (target == null)
                            return false;
                        
                        float angleToTarget = Quaternion.Angle(
                            transform.rotation,
                            Quaternion.LookRotation(target.Transform.position - transform.position));
                        
                        return angleToTarget < 1f;
                    }
                ));

            ReactiveVariable<bool> inAttackProcess = entity.InAttackProcess;

            ICondition fromAttackToRotateStateCondition = new FuncCondition(() => inAttackProcess.Value == false);
            
            AIStateMachine stateMachine = new ();
            
            stateMachine.AddState(rotateToTargetState);
            stateMachine.AddState(attackTriggerState);
            
            stateMachine.AddTransition(rotateToTargetState, attackTriggerState, fromRotateToAttackCondition);
            stateMachine.AddTransition(attackTriggerState, rotateToTargetState, fromAttackToRotateStateCondition);

            return stateMachine;
        }
    }
}