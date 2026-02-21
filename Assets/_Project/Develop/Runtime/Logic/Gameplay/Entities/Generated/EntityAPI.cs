namespace _Project.Develop.Runtime.Entities
{
	public partial class Entity
	{
		public Assets._Project.Develop.Runtime.Gameplay.Common.RigidbodyComponent RigidbodyC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Common.RigidbodyComponent>();

		public UnityEngine.Rigidbody Rigidbody => RigidbodyC.Value;

		public bool TryGetRigidbody(out UnityEngine.Rigidbody value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Common.RigidbodyComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Rigidbody);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddRigidbody(UnityEngine.Rigidbody value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Common.RigidbodyComponent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Gameplay.Common.TransformComponent TransformC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Common.TransformComponent>();

		public UnityEngine.Transform Transform => TransformC.Value;

		public bool TryGetTransform(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Common.TransformComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTransform(UnityEngine.Transform value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Common.TransformComponent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Gameplay.Common.CharacterControllerComponent CharacterControllerC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Common.CharacterControllerComponent>();

		public UnityEngine.CharacterController CharacterController => CharacterControllerC.Value;

		public bool TryGetCharacterController(out UnityEngine.CharacterController value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Common.CharacterControllerComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.CharacterController);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCharacterController(UnityEngine.CharacterController value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Common.CharacterControllerComponent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Gameplay.Common.NavMeshAgentComponent NavMeshAgentC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Common.NavMeshAgentComponent>();

		public UnityEngine.AI.NavMeshAgent NavMeshAgent => NavMeshAgentC.Value;

		public bool TryGetNavMeshAgent(out UnityEngine.AI.NavMeshAgent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Common.NavMeshAgentComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.AI.NavMeshAgent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddNavMeshAgent(UnityEngine.AI.NavMeshAgent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Common.NavMeshAgentComponent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.CapsuleColliderComponent CapsuleColliderC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.CapsuleColliderComponent>();

		public UnityEngine.CapsuleCollider CapsuleCollider => CapsuleColliderC.Value;

		public bool TryGetCapsuleCollider(out UnityEngine.CapsuleCollider value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.CapsuleColliderComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.CapsuleCollider);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCapsuleCollider(UnityEngine.CapsuleCollider value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.CapsuleColliderComponent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactsDetectingMask ContactsDetectingMaskC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactsDetectingMask>();

		public UnityEngine.LayerMask ContactsDetectingMask => ContactsDetectingMaskC.Value;

		public bool TryGetContactsDetectingMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactsDetectingMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddContactsDetectingMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactsDetectingMask() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactCollidersBuffer ContactCollidersBufferC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactCollidersBuffer>();

		public _Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> ContactCollidersBuffer => ContactCollidersBufferC.Value;

		public bool TryGetContactCollidersBuffer(out _Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactCollidersBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddContactCollidersBuffer(_Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactCollidersBuffer() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactEntitiesBuffer ContactEntitiesBufferC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactEntitiesBuffer>();

		public _Project.Develop.Runtime.Utilities.Buffer<_Project.Develop.Runtime.Entities.Entity> ContactEntitiesBuffer => ContactEntitiesBufferC.Value;

		public bool TryGetContactEntitiesBuffer(out _Project.Develop.Runtime.Utilities.Buffer<_Project.Develop.Runtime.Entities.Entity> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactEntitiesBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Buffer<_Project.Develop.Runtime.Entities.Entity>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddContactEntitiesBuffer(_Project.Develop.Runtime.Utilities.Buffer<_Project.Develop.Runtime.Entities.Entity> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.ContactEntitiesBuffer() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.DeathMask DeathMaskC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.DeathMask>();

		public UnityEngine.LayerMask DeathMask => DeathMaskC.Value;

		public bool TryGetDeathMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.DeathMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddDeathMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.DeathMask() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchDeathMask IsTouchDeathMaskC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchDeathMask>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> IsTouchDeathMask => IsTouchDeathMaskC.Value;

		public bool TryGetIsTouchDeathMask(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchDeathMask component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsTouchDeathMask()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchDeathMask() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsTouchDeathMask(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchDeathMask() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchAnotherTeam IsTouchAnotherTeamC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchAnotherTeam>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> IsTouchAnotherTeam => IsTouchAnotherTeamC.Value;

		public bool TryGetIsTouchAnotherTeam(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchAnotherTeam component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsTouchAnotherTeam()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchAnotherTeam() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsTouchAnotherTeam(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.IsTouchAnotherTeam() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.CurrentHealth CurrentHealthC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.CurrentHealth>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> CurrentHealth => CurrentHealthC.Value;

		public bool TryGetCurrentHealth(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.CurrentHealth component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCurrentHealth()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.CurrentHealth() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddCurrentHealth(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.CurrentHealth() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MaxHealth MaxHealthC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MaxHealth>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> MaxHealth => MaxHealthC.Value;

		public bool TryGetMaxHealth(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MaxHealth component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddMaxHealth()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MaxHealth() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddMaxHealth(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MaxHealth() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.IsDead IsDeadC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.IsDead>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> IsDead => IsDeadC.Value;

		public bool TryGetIsDead(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.IsDead component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsDead()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.IsDead() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsDead(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.IsDead() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MustDie MustDieC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MustDie>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustDie => MustDieC.Value;

		public bool TryGetMustDie(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MustDie component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddMustDie(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MustDie() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MustSelfRelease MustSelfReleaseC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MustSelfRelease>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustSelfRelease => MustSelfReleaseC.Value;

		public bool TryGetMustSelfRelease(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MustSelfRelease component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddMustSelfRelease(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.MustSelfRelease() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessInitialTime DeathProcessInitialTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessInitialTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> DeathProcessInitialTime => DeathProcessInitialTimeC.Value;

		public bool TryGetDeathProcessInitialTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddDeathProcessInitialTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessInitialTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddDeathProcessInitialTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessInitialTime() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessCurrentTime DeathProcessCurrentTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessCurrentTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> DeathProcessCurrentTime => DeathProcessCurrentTimeC.Value;

		public bool TryGetDeathProcessCurrentTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddDeathProcessCurrentTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessCurrentTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddDeathProcessCurrentTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DeathProcessCurrentTime() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.InDeathProcess InDeathProcessC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.InDeathProcess>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> InDeathProcess => InDeathProcessC.Value;

		public bool TryGetInDeathProcess(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.InDeathProcess component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddInDeathProcess()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.InDeathProcess() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddInDeathProcess(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.InDeathProcess() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DisableCollidersOnDeath DisableCollidersOnDeathC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DisableCollidersOnDeath>();

		public System.Collections.Generic.List<UnityEngine.Collider> DisableCollidersOnDeath => DisableCollidersOnDeathC.Value;

		public bool TryGetDisableCollidersOnDeath(out System.Collections.Generic.List<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DisableCollidersOnDeath component);
			if(result)
				value = component.Value;
			else
				value = default(System.Collections.Generic.List<UnityEngine.Collider>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddDisableCollidersOnDeath()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DisableCollidersOnDeath() { Value = new System.Collections.Generic.List<UnityEngine.Collider>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddDisableCollidersOnDeath(System.Collections.Generic.List<UnityEngine.Collider> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Lifetime.DisableCollidersOnDeath() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveDirection MoveDirectionC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveDirection>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3> MoveDirection => MoveDirectionC.Value;

		public bool TryGetMoveDirection(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveDirection component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddMoveDirection()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveDirection() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddMoveDirection(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveDirection() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveSpeed MoveSpeedC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveSpeed>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> MoveSpeed => MoveSpeedC.Value;

		public bool TryGetMoveSpeed(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveSpeed component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddMoveSpeed()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveSpeed() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddMoveSpeed(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.MoveSpeed() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.IsMoving IsMovingC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.IsMoving>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> IsMoving => IsMovingC.Value;

		public bool TryGetIsMoving(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.IsMoving component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsMoving()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.IsMoving() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsMoving(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.IsMoving() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanMove CanMoveC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanMove>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanMove => CanMoveC.Value;

		public bool TryGetCanMove(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanMove component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCanMove(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanMove() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotateDirection RotateDirectionC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotateDirection>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3> RotateDirection => RotateDirectionC.Value;

		public bool TryGetRotateDirection(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotateDirection component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddRotateDirection()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotateDirection() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddRotateDirection(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<UnityEngine.Vector3> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotateDirection() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotationSpeed RotationSpeedC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotationSpeed>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> RotationSpeed => RotationSpeedC.Value;

		public bool TryGetRotationSpeed(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotationSpeed component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddRotationSpeed()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotationSpeed() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddRotationSpeed(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.RotationSpeed() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanRotate CanRotateC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanRotate>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanRotate => CanRotateC.Value;

		public bool TryGetCanRotate(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanRotate component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCanRotate(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanRotate() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.JumpForce JumpForceC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.JumpForce>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> JumpForce => JumpForceC.Value;

		public bool TryGetJumpForce(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.JumpForce component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddJumpForce()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.JumpForce() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddJumpForce(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.JumpForce() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanJump CanJumpC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanJump>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanJump => CanJumpC.Value;

		public bool TryGetCanJump(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanJump component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCanJump(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Movement.CanJump() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageRequest TakeDamageRequestC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageRequest>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single> TakeDamageRequest => TakeDamageRequestC.Value;

		public bool TryGetTakeDamageRequest(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTakeDamageRequest()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageRequest() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddTakeDamageRequest(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageRequest() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageEvent TakeDamageEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single> TakeDamageEvent => TakeDamageEventC.Value;

		public bool TryGetTakeDamageEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTakeDamageEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddTakeDamageEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.TakeDamageEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.CanApplyDamage CanApplyDamageC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Damage.CanApplyDamage>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanApplyDamage => CanApplyDamageC.Value;

		public bool TryGetCanApplyDamage(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.CanApplyDamage component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCanApplyDamage(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.CanApplyDamage() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.BodyContactDamage BodyContactDamageC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Damage.BodyContactDamage>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> BodyContactDamage => BodyContactDamageC.Value;

		public bool TryGetBodyContactDamage(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.BodyContactDamage component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddBodyContactDamage()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.BodyContactDamage() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddBodyContactDamage(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Damage.BodyContactDamage() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackRequest StartAttackRequestC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackRequest>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent StartAttackRequest => StartAttackRequestC.Value;

		public bool TryGetStartAttackRequest(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddStartAttackRequest()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackRequest() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddStartAttackRequest(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackRequest() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackEvent StartAttackEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent StartAttackEvent => StartAttackEventC.Value;

		public bool TryGetStartAttackEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddStartAttackEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddStartAttackEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.StartAttackEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.CanStartAttack CanStartAttackC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.CanStartAttack>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanStartAttack => CanStartAttackC.Value;

		public bool TryGetCanStartAttack(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.CanStartAttack component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCanStartAttack(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.CanStartAttack() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.EndAttackEvent EndAttackEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.EndAttackEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent EndAttackEvent => EndAttackEventC.Value;

		public bool TryGetEndAttackEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.EndAttackEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddEndAttackEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.EndAttackEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddEndAttackEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.EndAttackEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessInitialTime AttackProcessInitialTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessInitialTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> AttackProcessInitialTime => AttackProcessInitialTimeC.Value;

		public bool TryGetAttackProcessInitialTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackProcessInitialTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessInitialTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackProcessInitialTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessInitialTime() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessCurrentTime AttackProcessCurrentTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessCurrentTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> AttackProcessCurrentTime => AttackProcessCurrentTimeC.Value;

		public bool TryGetAttackProcessCurrentTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackProcessCurrentTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessCurrentTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackProcessCurrentTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackProcessCurrentTime() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayTime AttackDelayTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> AttackDelayTime => AttackDelayTimeC.Value;

		public bool TryGetAttackDelayTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackDelayTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackDelayTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayTime() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayEndEvent AttackDelayEndEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayEndEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent AttackDelayEndEvent => AttackDelayEndEventC.Value;

		public bool TryGetAttackDelayEndEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayEndEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackDelayEndEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayEndEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackDelayEndEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackDelayEndEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackProcess InAttackProcessC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackProcess>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> InAttackProcess => InAttackProcessC.Value;

		public bool TryGetInAttackProcess(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackProcess component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddInAttackProcess()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackProcess() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddInAttackProcess(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackProcess() {Value = value}); 
		}

	}
}
