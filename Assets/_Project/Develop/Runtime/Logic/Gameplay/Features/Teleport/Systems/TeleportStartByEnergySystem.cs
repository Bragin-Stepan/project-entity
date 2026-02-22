using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class TeleportStartByEnergySystem: IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent<int> _useEnergyRequest;
        private ReactiveEvent _startTeleportRequest;
        private ReactiveEvent _startTeleportEvent;
        
        private ReactiveVariable<bool> _inTeleportProcess;
        private ReactiveVariable<int> _teleportCost;
        
        private ICompositeCondition _canStartTeleport;

        private IDisposable _teleportRequestDispose;

        public void OnInit(Entity entity)
        {
            _teleportCost = entity.EnergyTeleportCost;

            _useEnergyRequest = entity.UseEnergyRequest;
            _startTeleportRequest = entity.StartTeleportRequest;
            _startTeleportEvent = entity.StartTeleportEvent;
            _inTeleportProcess = entity.InTeleportProcess;
            
            _canStartTeleport = entity.CanStartTeleport;
            
            _teleportRequestDispose = _startTeleportRequest.Subscribe(OnTeleportRequest);
        }

        private void OnTeleportRequest()
        {
            if (_canStartTeleport.Evaluate())
            {
                Debug.Log("OnTeleportRequest");
                _inTeleportProcess.Value = true;
                _useEnergyRequest.Invoke(_teleportCost.Value);
                _startTeleportEvent.Invoke();
            }
        }

        public void OnDispose()
        {
            _teleportRequestDispose.Dispose();
        }
    }
}
