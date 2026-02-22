using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using Unity.Mathematics;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.Systems
{
    public class RegenEnergySystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent<int> _regenEnergyRequest;
        private ReactiveEvent<int> _regenEnergyEvent;
        
        private ReactiveVariable<int> _currentEnergy;
        private ReactiveVariable<int> _maxEnergy;
        
        private ICompositeCondition _canRegen;
        
        private IDisposable _regenRequestDispose;
        
        public void OnInit(Entity entity)
        {
            _currentEnergy = entity.CurrentEnergy;
            _maxEnergy = entity.MaxEnergy;
            
            _regenEnergyRequest = entity.RegenEnergyRequest;
            _regenEnergyEvent = entity.RegenEnergyEvent;
            
            _canRegen = entity.CanRegenEnergy;
    
            _regenRequestDispose = _regenEnergyRequest.Subscribe(OnRegenRequest);
        }
    
        private void OnRegenRequest(int value)
        {
            if (value <= 0)
                throw new ArgumentException($"Energy regen value must be positive. Received: {value}", nameof(value));
            
            if (_canRegen.Evaluate() == false)
                return;
            
            int energyDifference = _maxEnergy.Value - _currentEnergy.Value;
    
            if (energyDifference <= 0)
                return;
            
            int valueAdded = math.min(value, energyDifference);
            
            _currentEnergy.Value += valueAdded;
            
            _regenEnergyEvent.Invoke(value);
        }
    
        public void OnDispose()
        {
            _regenRequestDispose.Dispose();
        }
    }
}