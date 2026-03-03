using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public class RotateToTargetState : State, IUpdatableState
    {
        private ReactiveVariable<Vector3> _rotateDirection;
        private ReactiveVariable<Entity> _currentTarget;

        private Transform _transform;

        public RotateToTargetState(Entity entity)
        {
            _rotateDirection = entity.RotateDirection;
            _currentTarget = entity.CurrentTarget;
            _transform = entity.Transform;
        }

        public void Update(float deltaTime)
        {
            if (_currentTarget.Value != null)
                _rotateDirection.Value = (_currentTarget.Value.Transform.position - _transform.position).normalized;
        }
    }
}