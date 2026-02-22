using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class EndTeleportSystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveVariable<bool> _inTeleportProcess;
        
        private ReactiveEvent _findPointEvent;
        private ReactiveEvent _endTeleportEvent;
        
        private IDisposable _findEventDisposable;
        
        public void OnInit(Entity entity)
        {
            _findPointEvent = entity.FindTeleportPointEvent;
            _endTeleportEvent = entity.EndTeleportEvent;
            _inTeleportProcess = entity.InTeleportProcess;
            
            _findEventDisposable = _findPointEvent.Subscribe(OnFindEvent);
        }
        
        public void OnDispose()
        {
            _findEventDisposable.Dispose();
        }
        
        private void OnFindEvent()
        {
            _inTeleportProcess.Value = false;
            
            _endTeleportEvent.Invoke();
        }
    }
}