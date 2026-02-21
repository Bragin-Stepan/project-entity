using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Damage
{
    public class TakeDamageRequest : IEntityComponent { public ReactiveEvent<float> Value; }

    public class TakeDamageEvent : IEntityComponent { public ReactiveEvent<float> Value; }

    public class CanApplyDamage : IEntityComponent { public ICompositeCondition Value; }
    
    public class BodyContactDamage : IEntityComponent { public ReactiveVariable<float> Value; }
}