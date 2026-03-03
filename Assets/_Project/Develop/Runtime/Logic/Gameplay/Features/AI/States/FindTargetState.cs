using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public class FindTargetState : State, IUpdatableState
    {
        private ITargetSelector _targetSelector;
        private EntitiesLifeContext _entitiesLifeContext;
        private ReactiveVariable<Entity> _currentTarget;
        
        public FindTargetState(
            EntitiesLifeContext entitiesLifeContext,
            Entity entity,
            ITargetSelector targetSelector)
        {
            _currentTarget = entity.CurrentTarget;
            _targetSelector = targetSelector;
            _entitiesLifeContext = entitiesLifeContext;
        }
        
        public void Update(float deltaTime)
        {
            _currentTarget.Value = _targetSelector.SelectTargetFrom(_entitiesLifeContext.Entities);
        }
    }
}