using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI
{
    public class CurrentTarget : IEntityComponent { public ReactiveVariable<Entity> Value; }
}