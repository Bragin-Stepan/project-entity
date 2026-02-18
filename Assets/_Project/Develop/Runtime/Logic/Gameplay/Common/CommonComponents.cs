using _Project.Develop.Runtime.Entities;
using UnityEngine;
using UnityEngine.AI;

namespace Assets._Project.Develop.Runtime.Gameplay.Common
{
    public class RigidbodyComponent : IEntityComponent { public Rigidbody Value; }
    public class TransformComponent : IEntityComponent { public Transform Value; }
    public class CharacterControllerComponent : IEntityComponent { public CharacterController Value; }
    public class NavMeshAgentComponent : IEntityComponent { public NavMeshAgent Value; }
}
