using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class ProcessTeleportSystem : IInitializableSystem, IDisposableSystem
    {
        private Transform _target;
        private Transform _toPoint;

        private ReactiveEvent _startTeleportEvent;
        private ReactiveEvent _endTeleportEvent;

        private IDisposable _startTeleportEventDisposable;

        public void OnInit(Entity entity)
        {
            _target = entity.TeleportTarget;
            _toPoint = entity.TeleportToPoint;
            
            _startTeleportEvent = entity.StartTeleportEvent;
            _endTeleportEvent = entity.EndTeleportEvent;

            _startTeleportEventDisposable = _startTeleportEvent.Subscribe(OnStartTeleportProcess);
        }

        private void OnStartTeleportProcess()
        {
            _target.position = _toPoint.position;
            _endTeleportEvent.Invoke();
        }

        public void OnDispose()
        {
            _startTeleportEventDisposable.Dispose();
        }
    }
}