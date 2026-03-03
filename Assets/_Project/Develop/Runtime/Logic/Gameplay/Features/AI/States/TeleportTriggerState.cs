using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public class TeleportTriggerState : State, IUpdatableState
    {
        private ReactiveEvent _request;

        public TeleportTriggerState(Entity entity)
        {
            _request = entity.StartTeleportRequest;
        }

        public override void Enter()
        {
            base.Enter();
            _request.Invoke();
        }

        public void Update(float deltaTime)
        { }
    }
}