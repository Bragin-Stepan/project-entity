using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public class PlayerInputMovementState : State, IUpdatableState
    {
        private readonly IPlayerInput _playerInput;
        
        private ReactiveVariable<Vector3> _rotateDirection;
        private ReactiveVariable<Vector3> _moveDirection;
        
        public PlayerInputMovementState(Entity entity, IPlayerInput playerInput)
        {
            _playerInput = playerInput;

            _rotateDirection = entity.RotateDirection;
            _moveDirection = entity.MoveDirection;
        }

        public void Update(float deltaTime)
        {
            _moveDirection.Value = new Vector3(_playerInput.Move.Value.x, 0, _playerInput.Move.Value.y);
            _rotateDirection.Value = new Vector3(_playerInput.Move.Value.x, 0, _playerInput.Move.Value.y);
        }

        public override void Exit()
        {
            base.Exit();

            _moveDirection.Value = Vector3.zero;
        }
    }
}