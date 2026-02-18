using _Project.Develop.Runtime.Entities;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Gameplay.Common
{
    public class CharacterControllerEntityRegistrator : MonoEntityRegistrator
    {
        public override void Register(Entity entity)
        {
            entity.AddCharacterController(GetComponent<CharacterController>());
        }
    }
}