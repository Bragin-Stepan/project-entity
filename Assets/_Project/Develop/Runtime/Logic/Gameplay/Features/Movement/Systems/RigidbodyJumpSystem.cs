using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class RigidbodyJumpSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<float> _jumpForce;
        private Rigidbody _rigidbody;

        public void OnInit(Entity entity)
        {
            _jumpForce = entity.JumpForce;
            _rigidbody = entity.Rigidbody;
        }

        public void OnUpdate(float deltaTime)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce.Value, ForceMode.Impulse);
        }
    }
}