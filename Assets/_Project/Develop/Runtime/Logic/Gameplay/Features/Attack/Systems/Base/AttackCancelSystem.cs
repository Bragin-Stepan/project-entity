using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems
{
    public class AttackCancelSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<bool> _inAttackProcess;
        private ReactiveEvent _attackCanceledEvent;

        private ICompositeCondition _mustCancelAttack;

        public void OnInit(Entity entity)
        {
            _inAttackProcess = entity.InAttackProcess;
            _attackCanceledEvent = entity.AttackCanceledEvent;

            _mustCancelAttack = entity.MustCancelAttack;
        }

        public void OnUpdate(float deltaTime)
        {
            if (_inAttackProcess.Value == false)
                return;

            if (_mustCancelAttack.Evaluate())
            {
                _inAttackProcess.Value = false;
                _attackCanceledEvent.Invoke();
            }
        }
    }
}