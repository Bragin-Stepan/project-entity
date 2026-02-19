using System;
using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace _Project.Develop.Runtime.Utils.InputManagement.Inputs
{
    public abstract class InputBase : IDisposable
    {
        public bool IsEnabled { get; private set; }

        private readonly List<IDisposable> _disposables = new();
        
        protected InputState<T> Register<T>(InputAction action) where T : struct
        {
            InputState<T> state = new(action);
            
            if (state is IDisposable disposable)
                _disposables.Add(disposable);

            return state;
        }

        public virtual void Enable() => IsEnabled = true;

        public virtual void Disable() => IsEnabled = false;
        
        public virtual void Dispose()
        {
            Disable();
            
            foreach (IDisposable disposable in _disposables)
                disposable.Dispose();

            _disposables.Clear();
        }
    }
}