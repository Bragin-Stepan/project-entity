using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement.Event;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Energy
{
    public class CurrentEnergy : IEntityComponent { public ReactiveVariable<int> Value; }
    public class MaxEnergy : IEntityComponent { public ReactiveVariable<int> Value; }
    
    public class CanUseEnergy : IEntityComponent { public ICompositeCondition Value; }
    public class UseEnergyRequest : IEntityComponent { public ReactiveEvent<int> Value; }
    public class UseEnergyEvent : IEntityComponent { public ReactiveEvent<int> Value; }
    
    public class CanRegenEnergy : IEntityComponent { public ICompositeCondition Value; }
    public class RegenEnergyRequest : IEntityComponent { public ReactiveEvent<int> Value; }
    public class RegenEnergyEvent : IEntityComponent { public ReactiveEvent<int> Value; }
    
    public class AutoRegenEnergyAmount : IEntityComponent { public ReactiveVariable<int> Value; }
    public class IsAutoRegenEnergy : IEntityComponent { public ReactiveVariable<bool> Value; }
    public class EnergyAutoRegenInitialTime : IEntityComponent { public ReactiveVariable<float> Value; }
    public class EnergyAutoRegenCurrentTime : IEntityComponent { public ReactiveVariable<float> Value; }
}