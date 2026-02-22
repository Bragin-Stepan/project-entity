using _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.Systems.Shoot;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Damage;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.Systems;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Input;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.Systems;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Movement;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.Systems;
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
        private readonly IPlayerInput _playerInput;

        public EntitiesFactory(DIContainer container)
        {
            _collidersRegistryService = container.Resolve<CollidersRegistryService>();
            _entitiesLifeContext = container.Resolve<EntitiesLifeContext>();
            _monoEntitiesFactory = container.Resolve<MonoEntitiesFactory>();
            _playerInput = container.Resolve<IPlayerInput>();
        }
        
        public Entity CreateHero(Vector3 position)
        {
            Entity entity = CreateEmpty();
        
            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Hero);

            entity
                .AddMoveDirection()
                .AddRotateDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(10))
                .AddRotationSpeed(new ReactiveVariable<float>(800))
                .AddMaxHealth(new ReactiveVariable<float>(150))
                .AddCurrentHealth(new ReactiveVariable<float>(150))
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddIsDead()
                .AddIsMoving()
                .AddInDeathProcess()
                .AddDeathProcessInitialTime(new ReactiveVariable<float>(2))
                .AddDeathProcessCurrentTime()
                .AddAttackProcessInitialTime(new ReactiveVariable<float>(3))
                .AddAttackProcessCurrentTime()
                .AddInAttackProcess()
                .AddStartAttackRequest()
                .AddStartAttackEvent()
                .AddEndAttackEvent()
                .AddAttackDelayTime(new ReactiveVariable<float>(2))
                .AddAttackDelayEndEvent()
                .AddInstantAttackDamage(new ReactiveVariable<float>(50))
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
                .AddSystem(new AttackByInputSystem(_playerInput))
                .AddSystem(new MoveDirectionByInputSystem(_playerInput))
                .AddSystem(new RotateDirectionByMoveInputSystem(_playerInput))
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
        
            _entitiesLifeContext.Add(entity);
        
            return entity;
        }

        public Entity CreateMage(Vector3 position)
        {
            Entity entity = CreateEmpty();
        
            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Mage);
            
            return entity;
        }

        public Entity CreateGhost(Vector3 position)
        {
            Entity entity = CreateEmpty();
        
            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Ghost);

            entity
                .AddContactsDetectingMask(Layers.CharactersMask)
                .AddContactCollidersBuffer(new Buffer<Collider>(64))
                .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                .AddMoveDirection()
                .AddRotateDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(10))
                .AddRotationSpeed(new ReactiveVariable<float>(800))
                .AddMaxHealth(new ReactiveVariable<float>(150))
                .AddCurrentHealth(new ReactiveVariable<float>(150))
                .AddBodyContactDamage(new ReactiveVariable<float>(50))
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddIsDead()
                .AddIsMoving()
                .AddInDeathProcess()
                .AddDeathProcessInitialTime(new ReactiveVariable<float>(2))
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
        
            _entitiesLifeContext.Add(entity);
        
            return entity;
        }

        public Entity CreateTeleportWizard(Vector3 position)
        {
            Entity entity = CreateEmpty();
        
            _monoEntitiesFactory.Create(entity, position, PathToResources.Entity.Mage);

            entity
                .AddContactsDetectingMask(Layers.CharactersMask)
                .AddContactCollidersBuffer(new Buffer<Collider>(32))
                .AddContactEntitiesBuffer(new Buffer<Entity>(32))
                
                .AddMaxHealth(new ReactiveVariable<float>(150))
                .AddCurrentHealth(new ReactiveVariable<float>(150))
                
                .AddTeleportTarget(entity.Transform)
                .AddTeleportToPoint(entity.Transform)
                .AddStartTeleportEvent()
                .AddStartTeleportRequest()
                .AddInTeleportProcess()
                .AddFindTeleportPointEvent()
                .AddFindTeleportPointRequest()
                .AddEndTeleportEvent()
                
                .AddTeleportEnergyCost(new ReactiveVariable<int>(20))
                .AddTeleportSearchRadius(new ReactiveVariable<float>(6))
                
                .AddCurrentEnergy(new ReactiveVariable<int>(60))
                .AddMaxEnergy(new ReactiveVariable<int>(60))
                .AddUseEnergyEvent()
                .AddUseEnergyRequest()
                .AddRegenEnergyEvent()
                .AddRegenEnergyRequest()
                .AddAutoRegenEnergyAmount(new ReactiveVariable<int>(10))
                .AddIsAutoRegenEnergy(new ReactiveVariable<bool>(true))
                .AddEnergyAutoRegenCurrentTime()
                .AddEnergyAutoRegenInitialTime(new ReactiveVariable<float>(3))
                
                .AddBodyContactDamage(new ReactiveVariable<float>(50))
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddIsDead()
                .AddInDeathProcess()
                .AddDeathProcessInitialTime(new ReactiveVariable<float>(2))
                .AddDeathProcessCurrentTime();
            
            ICompositeCondition canRegenEnergy = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canUseEnergy = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));
            
            ICompositeCondition canStartTeleport = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false))
                .Add(new FuncCondition(() => entity.CurrentEnergy.Value >= entity.TeleportEnergyCost.Value));
            
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
                .AddSystem(new TeleportByInputSystem(_playerInput))
                
                // .AddSystem(new RegenEnergyByValueSystem())
                .AddSystem(new RegenEnergyByPercentageSystem())
                .AddSystem(new UseEnergySystem())
                .AddSystem(new AutoRegenEnergyTimerSystem())
                
                .AddSystem(new TeleportStartByEnergySystem())
                .AddSystem(new TeleportProcessSystem())
                .AddSystem(new FindRandomPointForTeleportSystem())
                .AddSystem(new EndTeleportSystem())
                .AddSystem(new InstantTeleportSystem())
                
                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService))
                
                .AddSystem(new DealDamageOnContactSystem())
                .AddSystem(new ApplyDamageSystem())
                
                .AddSystem(new DeathSwitcherSystem())
                .AddSystem(new DeathProcessTimerSystem())
                
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));
        
            _entitiesLifeContext.Add(entity);
        
            return entity;
        }
        
        public Entity CreateProjectile(Vector3 position, Vector3 direction, float damage)
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
                .AddIsDead()
                .AddIsMoving()
                .AddDeathMask(Layers.CharactersMask | Layers.EnvironmentMask)
                .AddIsTouchDeathMask();
            
            ICompositeCondition canMove = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canRotate = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));
            
            ICompositeCondition mustDie = new CompositeCondition()
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
                
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));
        
            _entitiesLifeContext.Add(entity);
        
            return entity;
        }

        private Entity CreateEmpty() => new();
    }
}
