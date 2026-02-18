namespace _Project.Develop.Runtime.Entities
{
    public interface IInitializableSystem: IEntitySystem
    {
        void OnInit(Entity entity);
    }
}
