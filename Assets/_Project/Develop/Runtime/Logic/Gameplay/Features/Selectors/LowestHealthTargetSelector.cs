using System.Collections.Generic;
using System.Linq;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Damage;
using _Project.Develop.Runtime.Utilities.Conditions;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Selectors
{
    public class LowestHealthTargetSelector : ITargetSelector
    {
        private readonly Entity _source;

        public LowestHealthTargetSelector(Entity entity)
        {
            _source = entity;
        }

        public Entity SelectTargetFrom(IEnumerable<Entity> targets)
        {
            IEnumerable<Entity> selectedTargets = FindSelectedTargets(targets);

            IEnumerable<Entity> enumerable = selectedTargets.ToList();

            if (enumerable.Any() == false)
                return null;

            Entity lowestHealthTarget = enumerable.First();
            float minHealth = lowestHealthTarget.CurrentHealth.Value;

            foreach (Entity target in enumerable)
            {
                float health = target.CurrentHealth.Value;

                if (health < minHealth)
                {
                    minHealth = health;
                    lowestHealthTarget = target;
                }
            }

            return lowestHealthTarget;
        }

        private IEnumerable<Entity> FindSelectedTargets(IEnumerable<Entity> targets)
        {
            return targets.Where(target =>
            {
                bool result = target.HasComponent<TakeDamageRequest>();

                if (target.TryGetCanApplyDamage(out ICompositeCondition value))
                    result = result && value.Evaluate();

                result = result && (target != _source);

                return result;
            });
        }
    }
}
