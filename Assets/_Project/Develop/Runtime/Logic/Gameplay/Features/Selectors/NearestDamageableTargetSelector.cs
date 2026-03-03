using System.Collections.Generic;
using System.Linq;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Damage;
using _Project.Develop.Runtime.Utilities.Conditions;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Selectors
{
    public class NearestDamageableTargetSelector : ITargetSelector
    {
        private readonly Entity _source;
        private readonly Transform _sourceTransform;

        public NearestDamageableTargetSelector(Entity entity)
        {
            _source = entity;
            _sourceTransform = entity.Transform;
        }

        public Entity SelectTargetFrom(IEnumerable<Entity> targets)
        {
            IEnumerable<Entity> selectedTargets = FindSelectedTargets(targets);

            IEnumerable<Entity> enumerable = selectedTargets.ToList();
            
            if (enumerable.Any() == false)
                return null;

            Entity closetsTarget = enumerable.First();
            float minDistance = GetDistanceTo(closetsTarget);

            foreach (Entity target in enumerable)
            {
                float distance = GetDistanceTo(target);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closetsTarget = target;
                }
            }
            
            return closetsTarget;
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
        
        private float GetDistanceTo(Entity target) => (_sourceTransform.position - target.Transform.position).magnitude;
    }
}