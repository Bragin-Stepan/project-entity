using _Project.Develop.Runtime.Entities;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors
{
    public class CapsuleColliderRegistrator : MonoEntityRegistrator
    {
        [SerializeField] private CapsuleCollider _collider; 
        
        public override void Register(Entity entity)
        {
            entity.AddCapsuleCollider(_collider);
        }
    }
}