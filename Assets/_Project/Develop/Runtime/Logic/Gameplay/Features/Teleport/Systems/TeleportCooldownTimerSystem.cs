using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems
{
    public class TeleportCooldownTimerSystem : IInitializableSystem, IUpdatableSystem, IDisposableSystem
    {
        private ReactiveVariable<float> _currentTime;
        private ReactiveVariable<float> _initialTime;
        private ReactiveVariable<bool> _inTeleportCooldown;

        private ReactiveEvent _endTeleportEvent;

        private IDisposable _endTeleportEventDisposable;

        public void OnInit(Entity entity)
        {
            _currentTime = entity.TeleportCooldownCurrentTime;
            _initialTime = entity.TeleportCooldownInitialTime;
            _inTeleportCooldown = entity.InTeleportCooldown;
            _endTeleportEvent = entity.EndTeleportEvent;

            _endTeleportEventDisposable = _endTeleportEvent.Subscribe(OnEndTeleport);
        }

        private void OnEndTeleport()
        {
            _currentTime.Value = _initialTime.Value;
            _inTeleportCooldown.Value = true;
        }

        public void OnUpdate(float deltaTime)
        {
            if (_inTeleportCooldown.Value == false)
                return;

            _currentTime.Value -= deltaTime;

            if (CooldownIsOver())
                _inTeleportCooldown.Value = false;
        }

        private bool CooldownIsOver() => _currentTime.Value <= 0;

        public void OnDispose()
        {
            _endTeleportEventDisposable.Dispose();
        }
    }
}