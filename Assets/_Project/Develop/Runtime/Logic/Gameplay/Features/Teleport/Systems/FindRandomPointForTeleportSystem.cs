using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class FindRandomPointForTeleportSystem : IInitializableSystem, IDisposableSystem
    {
        private Transform _toPoint;

        private ReactiveEvent _findPointRequest;
        private ReactiveEvent _findPointEvent;
        
        private ReactiveVariable<float> _radius;

        private IDisposable _findPointRequestDisposable;
        
        public void OnInit(Entity entity)
        {
            _toPoint = entity.TeleportToPoint;
            _radius = entity.TeleportSearchRadius;
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
            _toPoint.position = GetRandomPointByRadius(_radius.Value);
            _findPointEvent.Invoke();
        }
        
        private Vector3 GetRandomPointByRadius(float radius) 
            => new(Random.Range(0, radius), 0, Random.Range(0, radius));
    }
}