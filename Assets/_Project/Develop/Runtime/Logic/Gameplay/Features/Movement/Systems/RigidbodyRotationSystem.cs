using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class RigidbodyRotationSystem : IInitializableSystem, IUpdatableSystem
    {
        private Rigidbody _rigidbody;

        private ReactiveVariable<float> _speed;
        private ReactiveVariable<Vector3> _direction;

        public void OnInit(Entity entity)
        {
            _rigidbody = entity.Rigidbody;
            _speed = entity.RotationSpeed;
            _direction = entity.RotateDirection;
        }

        public void OnUpdate(float deltaTime)
        {
            if (_direction.Value == Vector3.zero)
                return;

            Quaternion lookRotation = Quaternion.LookRotation(_direction.Value.normalized);
            float step = _speed.Value * deltaTime;
            Quaternion rotation = Quaternion.RotateTowards(_rigidbody.rotation, lookRotation, step);

            _rigidbody.MoveRotation(rotation);
        }
    }
}