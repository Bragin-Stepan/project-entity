using _Project.Develop.Runtime.Configs.Gameplay.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems.Shoot;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Damage;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.Systems;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Input;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.Systems;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Movement;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.Systems;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Teams;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.Systems;
using _Project.Develop.Runtime.Utilities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.InputManagement;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Entities
{
    public class EntitiesFactory
    {
        private readonly EntitiesLifeContext _entitiesLifeContext;
        private readonly MonoEntitiesFactory _monoEntitiesFactory;
        private readonly CollidersRegistryService _collidersRegistryService;

        public EntitiesFactory(DIContainer container)
        {
            _collidersRegistryService = container.Resolve<CollidersRegistryService>();
            _entitiesLifeContext = container.Resolve<EntitiesLifeContext>();
            _monoEntitiesFactory = container.Resolve<MonoEntitiesFactory>();
        }

        public Entity CreateHero(Vector3 position, HeroConfigSO config)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Hero);

            entity
                .AddMoveDirection()
                .AddRotateDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(config.MoveSpeed))
                .AddRotationSpeed(new ReactiveVariable<float>(config.RotationSpeed))
                .AddMaxHealth(new ReactiveVariable<float>(config.MaxHealth))
                .AddCurrentHealth(new ReactiveVariable<float>(config.MaxHealth))
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddIsDead()
                .AddIsMoving()
                .AddInDeathProcess()
                .AddDeathProcessInitialTime(new ReactiveVariable<float>(config.DeathProcessTime))
                .AddDeathProcessCurrentTime()
                .AddAttackProcessInitialTime(new ReactiveVariable<float>(config.AttackProcessTime))
                .AddAttackProcessCurrentTime()
                .AddInAttackProcess()
                .AddStartAttackRequest()
                .AddStartAttackEvent()
                .AddEndAttackEvent()
                .AddAttackDelayTime(new ReactiveVariable<float>(config.AttackDelayTime))
                .AddAttackDelayEndEvent()
                .AddInstantAttackDamage(new ReactiveVariable<float>(config.InstantAttackDamage))
                .AddAttackCanceledEvent()
                .AddAttackCooldownInitialTime()
                .AddAttackCooldownCurrentTime()
                .AddInAttackCooldown();

            ICompositeCondition canMove = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canRotate = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition mustDie = new CompositeCondition()
                .Add(new FuncCondition(() => entity.CurrentHealth.Value <= 0));

            ICompositeCondition mustSelfRelease = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value))
                .Add(new FuncCondition(() => entity.InDeathProcess.Value == false));

            ICompositeCondition canApplyDamage = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canStartAttack = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false))
                .Add(new FuncCondition(() => entity.InAttackProcess.Value == false))
                .Add(new FuncCondition(() => entity.IsMoving.Value == false))
                .Add(new FuncCondition(() => entity.InAttackCooldown.Value == false));

            ICompositeCondition mustCancelAttack = new CompositeCondition(LogicOperationsUtils.Or)
                .Add(new FuncCondition(() => entity.IsDead.Value))
                .Add(new FuncCondition(() => entity.IsMoving.Value));

            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddCanApplyDamage(canApplyDamage)
                .AddMustDie(mustDie)
                .AddCanStartAttack(canStartAttack)
                .AddMustSelfRelease(mustSelfRelease)
                .AddMustCancelAttack(mustCancelAttack);

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())

                .AddSystem(new AttackCancelSystem())

                .AddSystem(new StartAttackSystem())
                .AddSystem(new ProcessAttackTimerSystem())
                .AddSystem(new AttackDelayEndTriggerSystem())
                .AddSystem(new InstantShootSystem(this))
                .AddSystem(new EndAttackSystem())
                .AddSystem(new AttackCooldownTimerSystem())

                .AddSystem(new ApplyDamageSystem())

                .AddSystem(new DeathSwitcherSystem())
                .AddSystem(new DeathProcessTimerSystem())

                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));

            return entity;
        }

        public Entity CreateGhost(Vector3 position, GhostConfigSO config)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Ghost);

            entity
                .AddContactsDetectingMask(Layers.CharactersMask)
                .AddContactCollidersBuffer(new Buffer<Collider>(64))
                .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                .AddMoveDirection()
                .AddRotateDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(config.MoveSpeed))
                .AddRotationSpeed(new ReactiveVariable<float>(config.RotationSpeed))
                .AddMaxHealth(new ReactiveVariable<float>(config.MaxHealth))
                .AddCurrentHealth(new ReactiveVariable<float>(config.MaxHealth))
                .AddBodyContactDamage(new ReactiveVariable<float>(config.BodyContactDamage))
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddIsDead()
                .AddIsMoving()
                .AddInDeathProcess()
                .AddDeathProcessInitialTime(new ReactiveVariable<float>(config.DeathProcessTime))
                .AddDeathProcessCurrentTime();

            ICompositeCondition canMove = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canRotate = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition mustDie = new CompositeCondition()
                .Add(new FuncCondition(() => entity.CurrentHealth.Value <= 0));

            ICompositeCondition mustSelfRelease = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value))
                .Add(new FuncCondition(() => entity.InDeathProcess.Value == false));

            ICompositeCondition canApplyDamage = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddCanApplyDamage(canApplyDamage)
                .AddMustDie(mustDie)
                .AddMustSelfRelease(mustSelfRelease);

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())

                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService))

                .AddSystem(new DealDamageOnContactSystem())
                .AddSystem(new ApplyDamageSystem())

                .AddSystem(new DeathSwitcherSystem())
                .AddSystem(new DeathProcessTimerSystem())

                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));

            return entity;
        }

        public Entity CreateTeleportWizard(Vector3 position, WizardConfigSO config)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Mage);

            entity
                .AddContactsDetectingMask(Layers.CharactersMask)
                .AddContactCollidersBuffer(new Buffer<Collider>(32))
                .AddContactEntitiesBuffer(new Buffer<Entity>(32))

                .AddMaxHealth(new ReactiveVariable<float>(config.MaxHealth))
                .AddCurrentHealth(new ReactiveVariable<float>(config.MaxHealth))

                .AddTeleportSource(entity.Transform)
                .AddTeleportToPoint(entity.Transform)
                .AddStartTeleportEvent()
                .AddStartTeleportRequest()
                .AddInTeleportProcess()
                .AddFindTeleportPointEvent()
                .AddFindTeleportPointRequest()
                .AddEndTeleportEvent()
                .AddCurrentTarget()

                .AddTeleportDamage(new ReactiveVariable<float>(config.TeleportDamage))
                .AddTeleportDamageRadius(new ReactiveVariable<float>(config.TeleportDamageRadius))
                .AddTeleportDamageMask(Layers.CharactersMask)

                .AddTeleportEnergyCost(new ReactiveVariable<int>(config.TeleportEnergyCast))
                .AddTeleportSearchRadius(new ReactiveVariable<float>(config.TeleportSearchRadius))
                
                .AddTeleportCooldownInitialTime(new ReactiveVariable<float>(config.TeleportCooldownTime))
                .AddTeleportCooldownCurrentTime(new ReactiveVariable<float>(config.TeleportCooldownTime))
                .AddInTeleportCooldown(new ReactiveVariable<bool>(true))

                .AddCurrentEnergy(new ReactiveVariable<int>(config.MaxEnergy))
                .AddMaxEnergy(new ReactiveVariable<int>(config.MaxEnergy))
                .AddUseEnergyEvent()
                .AddUseEnergyRequest()
                .AddRegenEnergyEvent()
                .AddRegenEnergyRequest()
                .AddAutoRegenEnergyAmount(new ReactiveVariable<int>(config.RegenEnergyAmount))
                .AddIsAutoRegenEnergy(new ReactiveVariable<bool>(true))
                .AddEnergyAutoRegenCurrentTime()
                .AddEnergyAutoRegenInitialTime(new ReactiveVariable<float>(config.AutoRegenEnergyTime))
                
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddIsDead()
                .AddInDeathProcess()
                .AddDeathProcessInitialTime(new ReactiveVariable<float>(config.DeathProcessTime))
                .AddDeathProcessCurrentTime();

            ICompositeCondition canRegenEnergy = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canUseEnergy = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canStartTeleport = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false))
                .Add(new FuncCondition(() => entity.InTeleportCooldown.Value == false))
                .Add(new FuncCondition(() => entity.CurrentEnergy.Value >= entity.TeleportEnergyCost.Value))
                .Add(new FuncCondition(() => entity.CurrentEnergy.Value >= entity.MaxEnergy.Value * 0.4f))
                .Add(new FuncCondition(() => entity.CurrentTarget.Value != null));

            ICompositeCondition mustDie = new CompositeCondition()
                .Add(new FuncCondition(() => entity.CurrentHealth.Value <= 0));

            ICompositeCondition mustSelfRelease = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value))
                .Add(new FuncCondition(() => entity.InDeathProcess.Value == false));

            ICompositeCondition canApplyDamage = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            entity
                .AddCanRegenEnergy(canRegenEnergy)
                .AddCanUseEnergy(canUseEnergy)
                .AddCanStartTeleport(canStartTeleport)
                .AddCanApplyDamage(canApplyDamage)
                .AddMustDie(mustDie)
                .AddMustSelfRelease(mustSelfRelease);

            entity
                // .AddSystem(new RegenEnergyByValueSystem())
                .AddSystem(new RegenEnergyByPercentageSystem())
                .AddSystem(new UseEnergySystem())
                .AddSystem(new AutoRegenEnergyTimerSystem())

                .AddSystem(new TeleportStartByEnergySystem())
                .AddSystem(new TeleportProcessSystem())
                // .AddSystem(new FindRandomPointForTeleportSystem())
                .AddSystem(new FindTargetPointForTeleportSystem())
                .AddSystem(new EndTeleportSystem())
                .AddSystem(new InstantTeleportSystem())
                .AddSystem(new TeleportCooldownTimerSystem())
                .AddSystem(new DealDamageAfterTeleportSystem(_collidersRegistryService))

                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService))

                // .AddSystem(new DealDamageOnContactSystem())
                .AddSystem(new ApplyDamageSystem())

                .AddSystem(new DeathSwitcherSystem())
                .AddSystem(new DeathProcessTimerSystem())

                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));

            return entity;
        }

        public Entity CreateProjectile(Vector3 position, Vector3 direction, float damage, Entity owner)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Projectile);

            entity
                .AddContactsDetectingMask(Layers.CharactersMask | Layers.EnvironmentMask)
                .AddContactCollidersBuffer(new Buffer<Collider>(64))
                .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                .AddMoveDirection(new ReactiveVariable<Vector3>(direction))
                .AddRotateDirection(new ReactiveVariable<Vector3>(direction))
                .AddMoveSpeed(new ReactiveVariable<float>(16))
                .AddRotationSpeed(new ReactiveVariable<float>(9999))
                .AddBodyContactDamage(new ReactiveVariable<float>(damage))
                .AddTeam(new ReactiveVariable<Teams>(owner.Team.Value))
                .AddIsDead()
                .AddIsMoving()
                .AddDeathMask(Layers.CharactersMask | Layers.EnvironmentMask)
                .AddIsTouchDeathMask()
                .AddIsTouchAnotherTeam();

            ICompositeCondition canMove = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canRotate = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition mustDie = new CompositeCondition(LogicOperationsUtils.Or)
                .Add(new FuncCondition(() => entity.IsTouchAnotherTeam.Value))
                .Add(new FuncCondition(() => entity.IsTouchDeathMask.Value));

            ICompositeCondition mustSelfRelease = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value));

            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfRelease(mustSelfRelease);

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())

                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService))

                .AddSystem(new DealDamageOnContactSystem())
                .AddSystem(new DeathMaskTouchDetectorSystem())
                .AddSystem(new DeathSwitcherSystem())

                .AddSystem(new AnotherTeamTouchDetectorSystem())
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));

            _entitiesLifeContext.Add(entity);

            return entity;
        }

        private Entity CreateEmpty() => new();
    }
}
