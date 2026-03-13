using UnityEngine;

namespace _Project.Develop.Runtime.Configs.Gameplay.Entities
{
    [CreateAssetMenu(menuName = "Configs/Gameplay/Entities/NewHeroConfig", fileName = "HeroConfig")]
    public class HeroConfigSO : EntityConfigSO
    {
        [field: SerializeField] public string PrefabPath { get; private set; } = "Entities/Hero";
        [field: SerializeField, Min(0)] public float MoveSpeed { get; private set; } = 10;
        [field: SerializeField, Min(0)] public float RotationSpeed { get; private set; } = 900;
        [field: SerializeField, Min(0)] public float AttackProcessTime { get; private set; } = 1f;
        [field: SerializeField, Min(0)] public float AttackDelayTime { get; private set; } = 0.1f;
        [field: SerializeField, Min(0)] public float AttackCooldown { get; private set; } = 1f;
        [field: SerializeField, Min(0)] public float InstantAttackDamage { get; private set; } = 50;
        [field: SerializeField, Min(0)] public float MaxHealth { get; private set; } = 150;
        [field: SerializeField, Min(0)] public float DeathProcessTime { get; private set; } = 2;
    }
}
