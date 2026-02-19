using _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.Systems;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Movement;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Entities
{
    public class EntitiesFactory
    {
        private readonly EntitiesLifeContext _entitiesLifeContext;
        private readonly MonoEntitiesFactory _monoEntitiesFactory;
        private readonly IPlayerInput _playerInput;

        public EntitiesFactory(DIContainer container)
        {
            _entitiesLifeContext = container.Resolve<EntitiesLifeContext>();
            _monoEntitiesFactory = container.Resolve<MonoEntitiesFactory>();
            _playerInput = container.Resolve<IPlayerInput>();
        }
        
        public Entity CreateGhostEntity(Vector3 position)
        {
            Entity entity = CreateEmpty();
        
            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Ghost);

            entity
                .AddMoveDirection()
                .AddRotateDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(10))
                .AddRotationSpeed(new ReactiveVariable<float>(800))
                .AddMaxHealth(new ReactiveVariable<float>(150))
                .AddCurrentHealth(new ReactiveVariable<float>(150))
                .AddIsDead()
                .AddIsMoving()
                .AddInDeathProcess()
                .AddDeathProcessInitialTime(new ReactiveVariable<float>(2))
                .AddDeathProcessCurrentTime();
            
            ICompositeCondition canMove = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canRotate = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));
            
            ICompositeCondition mustDie = new CompositeCondition()
                .Add(new FuncCondition(() => entity.CurrentHealth.Value <= 0));

            ICompositeCondition mustSelfRelease = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value))
                .Add(new FuncCondition(() => entity.InDeathProcess.Value == false));

            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfRelease(mustSelfRelease);

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new MoveDirectionByInputSystem(_playerInput))
                .AddSystem(new RotateDirectionByInputSystem(_playerInput))
                .AddSystem(new DeathSwitcherSystem())
                .AddSystem(new DeathProcessTimerSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));
        
            _entitiesLifeContext.Add(entity);
        
            return entity;
        }

        private Entity CreateEmpty() => new();
    }
}
