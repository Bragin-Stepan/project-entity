using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Input
{
    public class AttackByInputSystem : IInitializableSystem, IDisposableSystem
    {
        private readonly IPlayerInput _playerInput;
        
        private ReactiveEvent _startAttackRequest;

        public AttackByInputSystem(IPlayerInput playerInput)
        {
            _playerInput = playerInput;
        }

        public void OnInit(Entity entity)
        {
            _startAttackRequest = entity.StartAttackRequest;

            _playerInput.Attack.Enter += OnAttackRequest;
        }

        private void OnAttackRequest(float value)
        {
            _startAttackRequest.Invoke();
        }

        public void OnDispose()
        {
            _playerInput.Attack.Enter -= OnAttackRequest;
        }
    }
}