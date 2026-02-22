using UnityEngine;
using PlayerActions = UserInputAction.PlayerActions;

namespace _Project.Develop.Runtime.Utils.InputManagement.Inputs
{
    public class PlayerInput : InputBase, IPlayerInput
    {
        public InputState<Vector2> Move { get; }
        public InputState<Vector2> Look { get; }
        public InputState<float> Attack { get; }
        public InputState<float> Jump { get; }
        public InputState<float> Sprint { get; }
        public InputState<float> Interact { get; }
        public InputState<float> Crouch { get; }
        public InputState<float> Previous { get; }
        public InputState<float> Next { get; }
        
        private readonly PlayerActions _playerActions;
        
        public PlayerInput(PlayerActions playerActions)
        {
            _playerActions = playerActions;
            
            Move = Register<Vector2>(_playerActions.Move);
            Look = Register<Vector2>(_playerActions.Look);
            Jump = Register<float>(_playerActions.Jump);
            Attack = Register<float>(_playerActions.Attack);
            Sprint = Register<float>(_playerActions.Sprint);
            Interact = Register<float>(_playerActions.Interact);
            Crouch = Register<float>(_playerActions.Crouch);
            Previous = Register<float>(_playerActions.Previous);
            Next = Register<float>(_playerActions.Next);
        }

        public void Initialize()
        {
            Disable();
        }
        
        public override void Enable()
        {
            base.Enable();
            _playerActions.Enable();
        }
        
        public override void Disable()
        {
            base.Disable();
            _playerActions.Disable();
        }
    }
}


