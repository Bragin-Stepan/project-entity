using System;

namespace _Project.Develop.Runtime.Utils.InputManagement
{
    public interface IInput : IDisposable
    {
        bool IsEnabled { get; }
        
        void Enable();
        
        void Disable();
    }
}