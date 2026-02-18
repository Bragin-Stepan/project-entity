using _Project.Develop.Runtime.Entities;

namespace Assets._Project.Develop.Runtime.Gameplay.Common
{
    public class TransformEntityRegistrator : MonoEntityRegistrator
    {
        public override void Register(Entity entity)
        {
            entity.AddTransform(transform);
        }
    }
}