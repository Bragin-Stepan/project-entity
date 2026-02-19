using UnityEngine;

using UIActions = UserInputAction.UIActions;

namespace _Project.Develop.Runtime.Utils.InputManagement.Inputs
{
    public class UIInput : InputBase, IUIInput
    {
        public InputState<Vector2> Point { get; }
        public InputState<Vector2> Navigate { get; }
        public InputState<float> Click { get; }
        public InputState<float> RightClick { get; }
        public InputState<float> MiddleClick { get; }
        public InputState<Vector2> ScrollWheel { get; }
        // public InputState<Vector2> DeviceOrientation { get; }
        
        private readonly UIActions _uiActions;
        
        public UIInput(UIActions uiActions)
        {
            _uiActions = uiActions;
            
            Point = Register<Vector2>(_uiActions.Point);
            Navigate = Register<Vector2>(_uiActions.Navigate);
            Click = Register<float>(_uiActions.Click);
            RightClick = Register<float>(_uiActions.RightClick);
            MiddleClick = Register<float>(_uiActions.MiddleClick);
            ScrollWheel = Register<Vector2>(_uiActions.ScrollWheel);
            // DeviceOrientation = Register<Vector2>(_uiActions.TrackedDeviceOrientation);
        }

        public void Initialize()
        {
            Disable();
        }
        
        public override void Enable()
        {
            base.Enable();
            _uiActions.Enable();
        }
        
        public override void Disable()
        {
            base.Disable();
            _uiActions.Disable();
        }
    }
}