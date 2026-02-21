using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems
{
    public class AttackDelayEndTriggerSystem: IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent _attackDelayEndEvent;
        private ReactiveVariable<float> _delay;
        private ReactiveVariable<float> _attackProcessCurrentTime;

        private ReactiveEvent _startAttackEvent;

        private bool _alreadyAttacked;

        private IDisposable _timerDisposable;
        private IDisposable _startAttackDisposable;

        public void OnInit(Entity entity)
        {
            _attackDelayEndEvent = entity.AttackDelayEndEvent;
            _delay = entity.AttackDelayTime;
            _attackProcessCurrentTime = entity.AttackProcessCurrentTime;
            _startAttackEvent = entity.StartAttackEvent;

            _timerDisposable = _attackProcessCurrentTime.Subscribe(OnTimerChanged);
            _startAttackDisposable = _startAttackEvent.Subscribe(OnStartAttack);
        }

        private void OnStartAttack()
        {
            _alreadyAttacked = false;
        }

        private void OnTimerChanged(float arg1, float currentTime)
        {
            if (_alreadyAttacked)
                return;

            if(currentTime >= _delay.Value)
            {
                _attackDelayEndEvent.Invoke();
                _alreadyAttacked = true;
            }
        }

        public void OnDispose()
        {
            _timerDisposable.Dispose();
            _startAttackDisposable.Dispose();
        }
    }
}