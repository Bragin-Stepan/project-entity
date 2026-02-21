using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems
{
    public class EndAttackSystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent _endAttackEvent;
        private ReactiveVariable<bool> _inAttackProcess;
        private ReactiveVariable<float> _attackProcessInitialTime;
        private ReactiveVariable<float> _attackProcessCurrentTime;

        private IDisposable _timerDisposable;

        public void OnInit(Entity entity)
        {
            _endAttackEvent = entity.EndAttackEvent;
            _inAttackProcess = entity.InAttackProcess;
            _attackProcessInitialTime = entity.AttackProcessInitialTime;
            _attackProcessCurrentTime = entity.AttackProcessCurrentTime;

            _timerDisposable = _attackProcessCurrentTime.Subscribe(OnTimerChanged);
        }

        private void OnTimerChanged(float arg1, float currentTime)
        {
            if (TimeIsDone(currentTime))
            {
                _inAttackProcess.Value = false;
                _endAttackEvent.Invoke();
            }
        }

        public void OnDispose()
        {
            _timerDisposable.Dispose();
        }
        
        private bool TimeIsDone(float currentTime) => currentTime >= _attackProcessInitialTime.Value;
    }
}