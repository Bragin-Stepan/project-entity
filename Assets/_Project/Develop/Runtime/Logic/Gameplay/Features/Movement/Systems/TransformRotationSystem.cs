using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class TransformRotationSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<Vector3> _direction;
        private ReactiveVariable<float> _speed;
        private Transform _transform;
        private ICompositeCondition _canRotate;
        
        private const float DeadZone = 0.1f;

        public void OnInit(Entity entity)
        {
            _direction = entity.RotateDirection;
            _speed = entity.RotationSpeed;
            _transform = entity.Transform;
            _canRotate = entity.CanRotate;
            
            if (_direction.Value != Vector3.zero)
                _transform.rotation = Quaternion.LookRotation(_direction.Value.normalized);
        }

        public void OnUpdate(float deltaTime)
        {
            if (_canRotate.Evaluate() == false)
                return;
            
            if (_direction.Value.magnitude < DeadZone)
                return;
            
            Quaternion lookRotation = Quaternion.LookRotation(_direction.Value);
            float step = _speed.Value * deltaTime;
            
            _transform.rotation = Quaternion.RotateTowards(_transform.rotation, lookRotation, step);
        }
    }
}