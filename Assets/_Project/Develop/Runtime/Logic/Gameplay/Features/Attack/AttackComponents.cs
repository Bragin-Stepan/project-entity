using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Attack
{
    public class InstantAttackDamage : IEntityComponent { public ReactiveVariable<float> Value; }
    
    public class ShootPoint : IEntityComponent { public Transform Value; }
    
    public class CanStartAttack : IEntityComponent { public ICompositeCondition Value; }
    public class StartAttackRequest : IEntityComponent { public ReactiveEvent Value; }
    public class StartAttackEvent : IEntityComponent { public ReactiveEvent Value; }
    public class EndAttackEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class AttackProcessInitialTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class AttackProcessCurrentTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class InAttackProcess : IEntityComponent { public ReactiveVariable<bool> Value; }
    
    public class AttackDelayTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class AttackDelayEndEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class MustCancelAttack : IEntityComponent { public ICompositeCondition Value; }
    public class AttackCanceledEvent : IEntityComponent { public ReactiveEvent Value; }

    public class AttackCooldownInitialTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class AttackCooldownCurrentTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class InAttackCooldown : IEntityComponent { public ReactiveVariable<bool> Value; }
}