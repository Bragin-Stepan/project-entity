using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.Systems
{
    public class DeathSwitcherSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<bool> _isDead;
        private ICompositeCondition _mustDie;
        
        public void OnInit(Entity entity)
        {
            _isDead = entity.IsDead;
            _mustDie = entity.MustDie;
        }
        
        public void OnUpdate(float deltaTime)
        {
            if (_isDead.Value)
                return;
        
            if(_mustDie.Evaluate())
                _isDead.Value = true;
        }
    }
}