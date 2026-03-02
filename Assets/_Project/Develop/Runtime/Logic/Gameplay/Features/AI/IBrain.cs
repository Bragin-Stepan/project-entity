using System;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI
{
    public interface IBrain : IDisposable
    {
        void Enable();
        
        void Disable();
        
        void Update(float deltaTime);
        
    }
}