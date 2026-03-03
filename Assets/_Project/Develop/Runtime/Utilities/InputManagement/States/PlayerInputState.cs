using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace _Project.Develop.Runtime.Utils.InputManagement.States
{
    public class PlayerInputState : State
    {
        private readonly IPlayerInput _playerInput;
        
        public PlayerInputState(IPlayerInput playerInput)
        {
            _playerInput = playerInput;
        }

        public override void Enter()
        {
            base.Enter();
            _playerInput.Enable();
        }

        public override void Exit()
        {
            _playerInput.Disable();
            base.Exit();
        }
    }
}