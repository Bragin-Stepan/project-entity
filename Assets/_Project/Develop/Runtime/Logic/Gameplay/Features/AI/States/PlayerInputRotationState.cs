using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public class PlayerInputRotationState : State, IUpdatableState
    {
        private readonly IPlayerInput _playerInput;
        private readonly Transform _transform;
        
        private ReactiveVariable<Vector3> _rotateDirection;

        private const float Sensitivity = 0.5f;
        private const float DeadZone = 0.1f;

        public PlayerInputRotationState(Entity entity, IPlayerInput playerInput)
        {
            _playerInput = playerInput;
            _transform = entity.Transform;

            _rotateDirection = entity.RotateDirection;
        }

        public void Update(float deltaTime)
        {
            float lookX = _playerInput.Look.Value.x;

            if (Mathf.Abs(lookX) > DeadZone)
            {
                Vector3 currentDirection = _rotateDirection.Value;
                
                if (currentDirection == Vector3.zero)
                    currentDirection = _transform.forward;

                currentDirection.y = 0;
                
                if (currentDirection.sqrMagnitude < DeadZone)
                    currentDirection = Vector3.forward;
                
                currentDirection.Normalize();

                float angle = lookX * Sensitivity;
                Quaternion rotation = Quaternion.Euler(0, angle, 0);
                
                _rotateDirection.Value = rotation * currentDirection;
            }
        }
    }
}
