using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport
{
    public class TeleportSource : IEntityComponent { public Transform Value; }
    public class TeleportToPoint : IEntityComponent { public Transform Value; }
    public class TeleportSearchRadius : IEntityComponent { public ReactiveVariable<float> Value; }
    
    public class FindTeleportPointRequest : IEntityComponent { public ReactiveEvent Value; }
    public class FindTeleportPointEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class CanStartTeleport : IEntityComponent { public ICompositeCondition Value; }
    public class InTeleportProcess : IEntityComponent { public ReactiveVariable<bool> Value; }
    
    public class StartTeleportRequest : IEntityComponent { public ReactiveEvent Value; }
    public class StartTeleportEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class EndTeleportEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class TeleportEnergyCost : IEntityComponent { public ReactiveVariable<int> Value; }
    
    public class TeleportCooldownInitialTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class TeleportCooldownCurrentTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class InTeleportCooldown : IEntityComponent { public ReactiveVariable<bool> Value; }
    
    public class TeleportDamage : IEntityComponent { public ReactiveVariable<float> Value; }
    public class TeleportDamageRadius : IEntityComponent { public ReactiveVariable<float> Value; }
    public class TeleportDamageMask : IEntityComponent { public LayerMask Value; }
}