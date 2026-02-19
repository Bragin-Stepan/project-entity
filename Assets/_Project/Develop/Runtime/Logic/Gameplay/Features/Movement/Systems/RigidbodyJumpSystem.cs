using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class RigidbodyJumpSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<float> _jumpForce;
        private Rigidbody _rigidbody;
        
        private ICompositeCondition _canJump;

        public void OnInit(Entity entity)
        {
            _jumpForce = entity.JumpForce;
            _rigidbody = entity.Rigidbody;
            _canJump = entity.CanJump;
        }

        public void OnUpdate(float deltaTime)
        {
            if (_canJump.Evaluate() == false)
                return;
            
            _rigidbody.AddForce(Vector3.up * _jumpForce.Value, ForceMode.Impulse);
        }
    }
}