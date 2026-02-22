using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.Systems
{
    public class AutoRegenEnergyTimerSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveEvent<int> _regenEnergyRequest;
        
        private ReactiveVariable<float> _initialTime;
        private ReactiveVariable<float> _currentTime;
        
        private ReactiveVariable<int> _regenAmount;
        
        private ReactiveVariable<bool> _inAutoRegen;
        
        public void OnInit(Entity entity)
        {
            _inAutoRegen = entity.InAutoRegenEnergy;
            _regenAmount = entity.AutoRegenEnergyAmount;

            _initialTime = entity.EnergyAutoRegenInitialTime;
            _currentTime = entity.EnergyAutoRegenCurrentTime;
        }
        
        public void OnUpdate(float deltaTime)
        {
            if (_inAutoRegen.Value == false)
                return;

            _currentTime.Value += deltaTime;

            if (TimeIsDone(_currentTime.Value))
            {
                _currentTime.Value = 0;
                _regenEnergyRequest.Invoke(_regenAmount.Value);
            }
        }
        
        private bool TimeIsDone(float currentTime) => currentTime >= _initialTime.Value;
    }
}