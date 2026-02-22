using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Input
{
    public class TeleportByInputSystem : IInitializableSystem, IDisposableSystem
    {
        private readonly IPlayerInput _playerInput;
        
        private ReactiveEvent _startTeleportRequest;

        public TeleportByInputSystem(IPlayerInput playerInput)
        {
            _playerInput = playerInput;
        }

        public void OnInit(Entity entity)
        {
            _startTeleportRequest = entity.StartTeleportRequest;

            _playerInput.Jump.Enter += OnTeleportRequest;
        }

        private void OnTeleportRequest(float value)
        {
            _startTeleportRequest.Invoke();
        }

        public void OnDispose()
        {
            _playerInput.Jump.Enter -= OnTeleportRequest;
        }
    }
}