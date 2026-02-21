using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems
{
    public class ProcessAttackTimerSystem: IInitializableSystem, IDisposableSystem, IUpdatableSystem
    {
        private ReactiveVariable<float> _currentTime;
        private ReactiveVariable<bool> _inAttackProcess;
        private ReactiveEvent _startAttackEvent;

        private IDisposable _startAttackEventDisposable;

        public void OnInit(Entity entity)
        {
            _currentTime = entity.AttackProcessCurrentTime;
            _inAttackProcess = entity.InAttackProcess;
            _startAttackEvent = entity.StartAttackEvent;

            _startAttackEventDisposable = _startAttackEvent.Subscribe(OnStartAttackProcess);
        }

        private void OnStartAttackProcess()
        {
            _currentTime.Value = 0;
        }

        public void OnUpdate(float deltaTime)
        {
            if (_inAttackProcess.Value == false)
                return;

            _currentTime.Value += deltaTime;
        }

        public void OnDispose()
        {
            _startAttackEventDisposable.Dispose();
        }
    }
}