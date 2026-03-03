using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class FindTargetPointForTeleportSystem : IInitializableSystem, IDisposableSystem
    {
        private Transform _source;
        private Transform _toPoint;

        private ReactiveEvent _findPointRequest;
        private ReactiveEvent _findPointEvent;

        private ReactiveVariable<float> _radius;
        private ReactiveVariable<Entity> _currentTarget;

        private IDisposable _findPointRequestDisposable;

        public void OnInit(Entity entity)
        {
            _source = entity.TeleportSource;
            _toPoint = entity.TeleportToPoint;
            _radius = entity.TeleportSearchRadius;
            _currentTarget = entity.CurrentTarget;
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
            Entity target = _currentTarget.Value;

            if (target == null)
            {
                _toPoint.position = _source.position;
                _findPointEvent.Invoke();
                return;
            }

            Vector3 sourcePosition = _source.position;
            Vector3 targetPosition = target.Transform.position;
            Vector3 direction = targetPosition - sourcePosition;
            
            if (direction.magnitude <= _radius.Value)
                _toPoint.position = targetPosition;
            else
                _toPoint.position = sourcePosition + direction.normalized * _radius.Value;

            _findPointEvent.Invoke();
        }
    }
}
