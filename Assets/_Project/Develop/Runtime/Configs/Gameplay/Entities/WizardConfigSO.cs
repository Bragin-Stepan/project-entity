using UnityEngine;

namespace _Project.Develop.Runtime.Configs.Gameplay.Entities
{
    [CreateAssetMenu(menuName = "Configs/Gameplay/Entities/NewWizardConfig", fileName = "WizardConfig")]
    public class WizardConfigSO : EntityConfigSO
    {
        [field: SerializeField] public string PrefabPath { get; private set; } = "Entities/Wizard";
        [field: SerializeField, Min(0)] public float MoveSpeed { get; private set; } = 9;
        [field: SerializeField, Min(0)] public float RotationSpeed { get; private set; } = 900;
        [field: SerializeField, Min(0)] public float MaxHealth { get; private set; } = 100;
        [field: SerializeField, Min(0)] public float TeleportDamage { get; private set; } = 50;
        [field: SerializeField, Min(0)] public float TeleportDamageRadius { get; private set; } = 6;
        [field: SerializeField, Min(0)] public int TeleportEnergyCast { get; private set; } = 50;
        [field: SerializeField, Min(0)] public float TeleportSearchRadius { get; private set; } = 50;
        [field: SerializeField, Min(0)] public float TeleportCooldownTime { get; private set; } = 3;
       
        [field: SerializeField, Min(0)] public int MaxEnergy { get; private set; } = 60;
        [field: SerializeField, Min(0)] public int RegenEnergyAmount { get; private set; } = 10;
        [field: SerializeField, Min(0)] public float AutoRegenEnergyTime { get; private set; } = 2;
        
        [field: SerializeField, Min(0)] public float DeathProcessTime { get; private set; } = 2;
        [field: SerializeField, Min(0)] public float SpawnProcessTime { get; private set; } = 2;
    }
}