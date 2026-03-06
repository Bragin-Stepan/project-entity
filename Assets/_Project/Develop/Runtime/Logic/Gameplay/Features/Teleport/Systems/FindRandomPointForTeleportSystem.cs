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
        private Transform _source;
        private Transform _toPoint;

        private ReactiveEvent _findPointRequest;
        private ReactiveEvent _findPointEvent;

        private ReactiveVariable<float> _radius;

        private IDisposable _findPointRequestDisposable;

        public void OnInit(Entity entity)
        {
            _source = entity.TeleportSource;
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
            _toPoint.position = GetRandomPointInRadius(_source.position, _radius.Value);
            _findPointEvent.Invoke();
        }

        private Vector3 GetRandomPointInRadius(Vector3 center, float radius)
        {
            Vector2 randomPoint = Random.insideUnitCircle * radius;
            
            return center + new Vector3(randomPoint.x, 0f, randomPoint.y);
        }
    }
}