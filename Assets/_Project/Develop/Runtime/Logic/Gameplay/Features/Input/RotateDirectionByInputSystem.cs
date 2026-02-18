using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class RotateDirectionByInputSystem : IInitializableSystem, IUpdatableSystem
    {
        private readonly IPlayerInputService _playerInput;
        
        private ReactiveVariable<Vector3> _rotateDirection;

        public RotateDirectionByInputSystem(IPlayerInputService playerInput)
        {
            _playerInput = playerInput;
        }

        public void OnInit(Entity entity)
        {
            _rotateDirection = entity.RotateDirection;
        }

        public void OnUpdate(float deltaTime)
        {
            _rotateDirection.Value = new Vector3(_playerInput.Move.x, 0, _playerInput.Move.y);
        }
    }
}