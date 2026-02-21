using _Project.Develop.Runtime.Entities;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Attack
{
    public class ShootPointEntityRegistrator : MonoEntityRegistrator
    {
        [SerializeField] private Transform _shootPoint;

        public override void Register(Entity entity)
        {
            entity.AddShootPoint(_shootPoint);
        }
    }
}