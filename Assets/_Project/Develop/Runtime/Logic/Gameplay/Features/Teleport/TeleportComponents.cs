using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport
{
    public class TeleportTarget : IEntityComponent { public Transform Value; }
    public class TeleportToPoint : IEntityComponent { public Transform Value; }
    
    public class CanStartTeleport : IEntityComponent { public ICompositeCondition Value; }
    public class InTeleportProcess : IEntityComponent { public ReactiveVariable<bool> Value; }
    
    public class StartTeleportRequest : IEntityComponent { public ReactiveEvent Value; }
    public class StartTeleportEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class EndTeleportEvent : IEntityComponent { public ReactiveEvent Value; }
    
    public class EnergyTeleportCost : IEntityComponent { public ReactiveVariable<int> Value; }
}