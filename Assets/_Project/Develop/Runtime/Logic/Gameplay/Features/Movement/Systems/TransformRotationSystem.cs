using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class TransformRotationSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<Vector3> _direction;
        private ReactiveVariable<float> _speed;
        private Transform _transform;
        
        private const float DeadZone = 0.1f;

        public void OnInit(Entity entity)
        {
            _direction = entity.RotateDirection;
            _speed = entity.RotationSpeed;
            _transform = entity.Transform;
        }

        public void OnUpdate(float deltaTime)
        {
            if (_direction.Value.magnitude < DeadZone)
                return;
            
            Quaternion lookRotation = Quaternion.LookRotation(_direction.Value);
            float step = _speed.Value * deltaTime;
            
            _transform.rotation = Quaternion.RotateTowards(_transform.rotation, lookRotation, step);
        }
    }
}