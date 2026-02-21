using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Attack
{
    public class StartAttackRequest : IEntityComponent { public ReactiveEvent Value; }
    public class StartAttackEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class CanStartAttack : IEntityComponent { public ICompositeCondition Value; }

    public class EndAttackEvent : IEntityComponent { public ReactiveEvent Value; }

    public class AttackProcessInitialTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class AttackProcessCurrentTime : IEntityComponent { public ReactiveVariable<float> Value; }

    public class AttackDelayTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class AttackDelayEndEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class InAttackProcess : IEntityComponent { public ReactiveVariable<bool> Value; }
}