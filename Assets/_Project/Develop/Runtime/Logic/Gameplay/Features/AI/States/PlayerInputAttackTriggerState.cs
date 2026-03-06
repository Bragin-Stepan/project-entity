using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public class PlayerInputAttackTriggerState : State, IUpdatableState
    {
        private readonly IPlayerInput _playerInput;
        private ReactiveEvent _request;
        
        public PlayerInputAttackTriggerState(Entity entity, IPlayerInput playerInput)
        {
            _playerInput = playerInput;

            _request = entity.StartAttackRequest;
            _playerInput.Attack.Enter += OnAttack;
        }
        
        public void Update(float deltaTime)
        { }

        public override void Exit()
        {
            base.Exit();
            _playerInput.Attack.Enter -= OnAttack;
        }
        
        private void OnAttack(float value)
        {
            _request.Invoke();
        }
    }
}