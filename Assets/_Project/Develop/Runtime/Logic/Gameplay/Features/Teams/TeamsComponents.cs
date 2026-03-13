using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teams
{
    public class Team : IEntityComponent
    {
        public ReactiveVariable<Teams> Value;
    }
}