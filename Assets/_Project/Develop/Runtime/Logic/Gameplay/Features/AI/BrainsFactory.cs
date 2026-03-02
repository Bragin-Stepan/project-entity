using System;
using System.Collections.Generic;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States;
using _Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Timer;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI
{
    public class BrainsFactory
    {
        private readonly DIContainer _container;

        private readonly AIBrainsContext _aiBrainsContext;
        private readonly TimerServiceFactory _timerServiceFactory;
        
        public BrainsFactory(DIContainer container)
        {
            _container = container;
            _aiBrainsContext = _container.Resolve<AIBrainsContext>();
            _timerServiceFactory = _container.Resolve<TimerServiceFactory>();
        }

        public StateMachineBrain CreateGhostBrain(Entity entity)
        {
            AIStateMachine stateMachine = CreateRandomMovementStateMachine(entity);
            StateMachineBrain brain = new (stateMachine);
            
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
    }
}