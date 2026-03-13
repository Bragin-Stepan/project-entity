using _Project.Develop.Runtime.Logic.Gameplay.Features.Teams;
using _Project.Develop.Runtime.Utils.ReactiveManagement;

namespace _Project.Develop.Runtime.Entities
{
    public static class EntitiesHelper
    {
        public static bool AreOnSameTeam(Entity first, Entity second)
        {
            if (first.TryGetTeam(out ReactiveVariable<Teams> firstTeam) &&
                second.TryGetTeam(out ReactiveVariable<Teams> secondTeam))
            {
                return firstTeam.Value == secondTeam.Value;
            }

            return false;
        }
    }
}