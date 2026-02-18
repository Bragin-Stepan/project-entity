using UnityEngine;

namespace _Project.Develop.Runtime.Entities
{
    public abstract class MonoEntityRegistrator : MonoBehaviour
    {
        public abstract void Register(Entity entity);
    }
}
