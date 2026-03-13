using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems
{
    public class StartAttackSystem : IInitializableSystem, IDisposableSystem
    {
        private ReactiveEvent _startAttackRequest;
        private ReactiveEvent _startAttackEvent;
        private ReactiveVariable<bool> _inAttackProcess;
        private ICompositeCondition _canStartAttack;

        private Entity _entity;
        private ReactiveVariable<Entity> _currentTarget;
        private IDisposable _attackRequestDisposable;

        public void OnInit(Entity entity)
        {
            _entity = entity;
            _startAttackRequest = entity.StartAttackRequest;
            _startAttackEvent = entity.StartAttackEvent;
            _inAttackProcess = entity.InAttackProcess;
            _canStartAttack = entity.CanStartAttack;

            if (entity.TryGetCurrentTarget(out var currentTarget))
                _currentTarget = currentTarget;

            _attackRequestDisposable = _startAttackRequest.Subscribe(OnAttackRequest);
        }
        
        private void OnAttackRequest()
        {
            if (_canStartAttack.Evaluate())
            {
                if (_currentTarget != null && _currentTarget.Value != null)
                {
                    if (EntitiesHelper.AreOnSameTeam(_entity, _currentTarget.Value))
                    {
                        Debug.Log("Не могу атаковать своего!");
                        return;
                    }
                }

                _inAttackProcess.Value = true;
                _startAttackEvent.Invoke();
                Debug.Log("Старт атаки");
            }
            else
            {
                Debug.Log("Не могу атаковать!");
            }
        }

        public void OnDispose()
        {
            _attackRequestDisposable.Dispose();
        }
    }
}