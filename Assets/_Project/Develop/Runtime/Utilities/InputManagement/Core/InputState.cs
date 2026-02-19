using System;
using UnityEngine.InputSystem;

namespace _Project.Develop.Runtime.Utils.InputManagement
{
    public class InputState<T> : IDisposable where T : struct
    {
        public event Action<T> Enter;
        public event Action<T> Perform;
        public event Action<T> Exit;
        
        public bool IsActive { get; private set; }
        public T Value { get; private set; }
        
        private readonly InputAction _inputAction;
        
        public InputState(InputAction inputAction)
        {
            _inputAction = inputAction;
            Subscribe();
        }
        
        private void Subscribe()
        {
            _inputAction.started += OnStarted;
            _inputAction.performed += OnPerformed;
            _inputAction.canceled += OnCanceled;
        }
        
        private void Unsubscribe()
        {
            _inputAction.started -= OnStarted;
            _inputAction.performed -= OnPerformed;
            _inputAction.canceled -= OnCanceled;
        }
        
        private void OnStarted(InputAction.CallbackContext ctx)
        {
            T value = ctx.ReadValue<T>();
            Value = value;
            IsActive = true;
            Enter?.Invoke(value);
        }
        
        private void OnPerformed(InputAction.CallbackContext ctx)
        {
            T value = ctx.ReadValue<T>();
            Value = value;
            Perform?.Invoke(value);
        }
        
        private void OnCanceled(InputAction.CallbackContext ctx)
        {
            T value = ctx.ReadValue<T>();
            Value = value;
            IsActive = false;
            Exit?.Invoke(value);
        }
        
        public void Dispose()
        {
            Unsubscribe();
            Enter = null;
            Perform = null;
            Exit = null;
        }
    }
}