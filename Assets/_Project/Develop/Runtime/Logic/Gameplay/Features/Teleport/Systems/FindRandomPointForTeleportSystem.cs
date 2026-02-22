using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class FindRandomPointForTeleportSystem : IInitializableSystem, IDisposableSystem
    {
        private Transform _toPoint;

        private ReactiveEvent _findPointRequest;
        private ReactiveEvent _findPointEvent;

        private IDisposable _findPointRequestDisposable;
        
        public void OnInit(Entity entity)
        {
            _toPoint = entity.TeleportToPoint;
            _findPointRequest = entity.FindTeleportPointRequest;
            _findPointEvent = entity.FindTeleportPointEvent;
            
            _findPointRequestDisposable = _findPointRequest.Subscribe(OnFindPointRequest);
        }
        
        public void OnDispose()
        {
            _findPointRequestDisposable.Dispose();
        }
        
        private void OnFindPointRequest()
        {
            _toPoint.position = Vector3.zero;
            _findPointEvent.Invoke();
        }
    }
}