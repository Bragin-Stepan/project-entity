using _Project.Develop.Runtime.Entities;
using UnityEngine.AI;

namespace Assets._Project.Develop.Runtime.Gameplay.Common
{
    public class NavMeshAgentEntityRegistrator : MonoEntityRegistrator
    {
        public override void Register(Entity entity)
        {
            entity.AddNavMeshAgent(GetComponent<NavMeshAgent>());
        }
    }
}