using _Project.Develop.Runtime.Logic.Gameplay.Features.Movement;
using _Project.Develop.Runtime.Utilities.InputManagement;
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
        private readonly IPlayerInputService _playerInput;

        public EntitiesFactory(DIContainer container)
        {
            _entitiesLifeContext = container.Resolve<EntitiesLifeContext>();
            _monoEntitiesFactory = container.Resolve<MonoEntitiesFactory>();
            _playerInput = container.Resolve<IPlayerInputService>();
        }

        public Entity CreateTestEntity(Vector3 position)
        {
            Entity entity = CreateEmpty();
        
            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.TestEntity);
        
            entity
                .AddMoveDirection()
                .AddRotateDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(10))
                .AddRotationSpeed(new ReactiveVariable<float>(800));
        
            entity
                .AddSystem(new CharacterControllerMovementSystem())
                .AddSystem(new TransformRotationSystem())
                // .AddSystem(new RigidbodyMovementSystem())
                // .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new MoveDirectionByInputSystem(_playerInput))
                .AddSystem(new RotateDirectionByInputSystem(_playerInput));
        
            _entitiesLifeContext.Add(entity);
        
            return entity;
        }

        private Entity CreateEmpty() => new();
    }
}
