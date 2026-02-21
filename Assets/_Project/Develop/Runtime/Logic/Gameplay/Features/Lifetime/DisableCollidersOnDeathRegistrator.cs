using System.Collections.Generic;
using _Project.Develop.Runtime.Entities;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime
{
    public class DisableCollidersOnDeathRegistrator : MonoEntityRegistrator
    {
        [SerializeField] private List<Collider> _colliders;

        public override void Register(Entity entity)
        {
            entity.AddDisableCollidersOnDeath(_colliders);
        }
    }
}