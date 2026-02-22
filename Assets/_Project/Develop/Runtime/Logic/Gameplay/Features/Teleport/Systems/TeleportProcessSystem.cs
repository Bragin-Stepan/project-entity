using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class TeleportProcessSystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent _findPointRequest;
        private ReactiveVariable<bool> _inTeleportProcess;
        
        private ReactiveEvent _startTeleportEvent;

        private IDisposable _startTeleportEventDisposable;

        public void OnInit(Entity entity)
        {
            _findPointRequest = entity.FindTeleportPointRequest;
            
            _startTeleportEventDisposable = _startTeleportEvent.Subscribe(OnStartTeleportProcess);
        }

        private void OnStartTeleportProcess()
        {
            _findPointRequest.Invoke();
        }

        public void OnDispose()
        {
            _startTeleportEventDisposable.Dispose();
        }
    }
}