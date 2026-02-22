using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.Systems
{
    public class UseEnergySystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent<int> _useEnergyRequest;
        private ReactiveEvent<int> _useEnergyEvent;
        
        private ReactiveVariable<int> _currentEnergy;
        
        private ICompositeCondition _canUse;
        
        private IDisposable _useRequestDispose;
        
        public void OnInit(Entity entity)
        {
            _currentEnergy = entity.CurrentEnergy;

            _useEnergyRequest = entity.UseEnergyRequest;
            _useEnergyEvent = entity.UseEnergyEvent;
            
            _canUse = entity.CanUseEnergy;
    
            _useRequestDispose = _useEnergyRequest.Subscribe(OnUseRequest);
        }
    
        private void OnUseRequest(int value)
        {
            if (value <= 0)
                throw new ArgumentException($"Energy use value must be positive. Received: {value}", nameof(value));
            
            if (_canUse.Evaluate() == false)
                return;
            
            _currentEnergy.Value -= value;
            
            _useEnergyEvent.Invoke(value);
        }
    
        public void OnDispose()
        {
            _useRequestDispose.Dispose();
        }
    }
}