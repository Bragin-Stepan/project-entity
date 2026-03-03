using System.Collections.Generic;
using _Project.Develop.Runtime.Entities;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public interface ITargetSelector
    {
        public Entity SelectTargetFrom(IEnumerable<Entity> targets);
    }
}