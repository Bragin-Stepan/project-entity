using System;
using System.Collections.Generic;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class DealDamageAfterTeleportSystem : IInitializableSystem, IDisposableSystem
    {
        private Entity _entity;
        private Transform _toPoint;
        private ReactiveEvent _endTeleportEvent;
        
        private float _damage;
        private float _radius;
        private LayerMask _mask;
        
        private readonly CollidersRegistryService _collidersRegistryService;
        private readonly Collider[] _contacts = new Collider[32];
        
        private IDisposable _endTeleportDisposable;

        public DealDamageAfterTeleportSystem(CollidersRegistryService collidersRegistryService)
        {
            _collidersRegistryService = collidersRegistryService;
        }

        public void OnInit(Entity entity)
        {
            _entity = entity;
            _toPoint = entity.TeleportToPoint;
            _endTeleportEvent = entity.EndTeleportEvent;
            _damage = entity.TeleportDamage.Value;
            _radius = entity.TeleportDamageRadius.Value;
            _mask = entity.TeleportDamageMask;

            _endTeleportDisposable = _endTeleportEvent.Subscribe(OnEndTeleport);
        }

        public void OnDispose()
        {
            _endTeleportDisposable.Dispose();
        }

        private void OnEndTeleport()
        {
            if (_radius <= 0 || _damage <= 0) return;

            int count = Physics.OverlapSphereNonAlloc(
                _toPoint.position,
                _radius,
                _contacts,
                _mask,
                QueryTriggerInteraction.Ignore);
            
            for (int i = 0; i < count; i++)
            {
                Entity contactEntity = _collidersRegistryService.GetBy(_contacts[i]);
                
                if (contactEntity != null
                    && contactEntity != _entity
                    && contactEntity.TryGetTakeDamageRequest(out ReactiveEvent<float> takeDamageRequest))
                {
                    takeDamageRequest.Invoke(_damage);
                }
            }
        }
    }
}
