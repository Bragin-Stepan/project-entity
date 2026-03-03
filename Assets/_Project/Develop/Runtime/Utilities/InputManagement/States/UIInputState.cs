using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace _Project.Develop.Runtime.Utils.InputManagement.States
{
    public class UIInputState : State
    {
        private readonly IUIInput _uiInput;
        
        public UIInputState(IUIInput uiInput)
        {
            _uiInput = uiInput;
        }
        
        public override void Enter()
        {
            base.Enter();
            _uiInput.Enable();
        }

        public override void Exit()
        {
            _uiInput.Disable();
            base.Exit();
        }
    }
}