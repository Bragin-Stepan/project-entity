namespace _Project.Develop.Runtime.Entities
{
    public interface IUpdatableSystem : IEntitySystem
    {
        void OnUpdate(float deltaTime);
    }
}
