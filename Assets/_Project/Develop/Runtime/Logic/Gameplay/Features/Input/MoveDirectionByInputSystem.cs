using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class MoveDirectionByInputSystem : IInitializableSystem, IUpdatableSystem
    {
        private readonly IPlayerInputService _playerInput;
        
        private ReactiveVariable<Vector3> _moveDirection;

        public MoveDirectionByInputSystem(IPlayerInputService playerInput)
        {
            _playerInput = playerInput;
        }

        public void OnInit(Entity entity)
        {
            _moveDirection = entity.MoveDirection;
        }

        public void OnUpdate(float deltaTime)
        {
            _moveDirection.Value = new Vector3(_playerInput.Move.x, 0, _playerInput.Move.y);
        }
    }
}