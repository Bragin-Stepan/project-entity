using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class InstantTeleportSystem : IInitializableSystem, IDisposableSystem
    {
        private Transform _target;
        private Transform _toPoint;
        
        private ReactiveEvent _endTeleportEvent;
        
        private IDisposable _endTeleportDisposable;
        
        public void OnInit(Entity entity)
        {
            _target = entity.TeleportSource;
            _toPoint = entity.TeleportToPoint;
            _endTeleportEvent = entity.EndTeleportEvent;
            
            _endTeleportDisposable = _endTeleportEvent.Subscribe(OnEndTeleport);
        }
        
        public void OnDispose()
        {
            _endTeleportDisposable.Dispose();
        }
        
        private void OnEndTeleport()
        {
            _target.position = _toPoint.position;
        }
    }
}