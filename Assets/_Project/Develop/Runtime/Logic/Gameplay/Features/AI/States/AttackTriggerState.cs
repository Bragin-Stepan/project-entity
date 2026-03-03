using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public class AttackTriggerState : State, IUpdatableState
    {
        private ReactiveEvent _attackRequest;

        public AttackTriggerState(Entity entity)
        {
            _attackRequest = entity.StartAttackRequest;
        }

        public override void Enter()
        {
            base.Enter();
            _attackRequest.Invoke();
        }

        public void Update(float deltaTime)
        { }
    }
}