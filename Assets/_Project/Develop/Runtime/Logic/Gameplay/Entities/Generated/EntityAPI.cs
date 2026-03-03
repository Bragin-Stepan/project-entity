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

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportTarget TeleportTargetC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportTarget>();

		public UnityEngine.Transform TeleportTarget => TeleportTargetC.Value;

		public bool TryGetTeleportTarget(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportTarget component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportTarget(UnityEngine.Transform value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportTarget() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportToPoint TeleportToPointC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportToPoint>();

		public UnityEngine.Transform TeleportToPoint => TeleportToPointC.Value;

		public bool TryGetTeleportToPoint(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportToPoint component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportToPoint(UnityEngine.Transform value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportToPoint() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportSearchRadius TeleportSearchRadiusC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportSearchRadius>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> TeleportSearchRadius => TeleportSearchRadiusC.Value;

		public bool TryGetTeleportSearchRadius(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportSearchRadius component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportSearchRadius()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportSearchRadius() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportSearchRadius(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportSearchRadius() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointRequest FindTeleportPointRequestC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointRequest>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent FindTeleportPointRequest => FindTeleportPointRequestC.Value;

		public bool TryGetFindTeleportPointRequest(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddFindTeleportPointRequest()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointRequest() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddFindTeleportPointRequest(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointRequest() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointEvent FindTeleportPointEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent FindTeleportPointEvent => FindTeleportPointEventC.Value;

		public bool TryGetFindTeleportPointEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddFindTeleportPointEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddFindTeleportPointEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.FindTeleportPointEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.CanStartTeleport CanStartTeleportC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.CanStartTeleport>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanStartTeleport => CanStartTeleportC.Value;

		public bool TryGetCanStartTeleport(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.CanStartTeleport component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCanStartTeleport(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.CanStartTeleport() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.InTeleportProcess InTeleportProcessC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.InTeleportProcess>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> InTeleportProcess => InTeleportProcessC.Value;

		public bool TryGetInTeleportProcess(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.InTeleportProcess component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddInTeleportProcess()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.InTeleportProcess() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddInTeleportProcess(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.InTeleportProcess() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportRequest StartTeleportRequestC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportRequest>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent StartTeleportRequest => StartTeleportRequestC.Value;

		public bool TryGetStartTeleportRequest(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddStartTeleportRequest()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportRequest() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddStartTeleportRequest(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportRequest() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportEvent StartTeleportEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent StartTeleportEvent => StartTeleportEventC.Value;

		public bool TryGetStartTeleportEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddStartTeleportEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddStartTeleportEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.StartTeleportEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.EndTeleportEvent EndTeleportEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.EndTeleportEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent EndTeleportEvent => EndTeleportEventC.Value;

		public bool TryGetEndTeleportEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.EndTeleportEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddEndTeleportEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.EndTeleportEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddEndTeleportEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.EndTeleportEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportEnergyCost TeleportEnergyCostC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportEnergyCost>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> TeleportEnergyCost => TeleportEnergyCostC.Value;

		public bool TryGetTeleportEnergyCost(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportEnergyCost component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportEnergyCost()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportEnergyCost() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportEnergyCost(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportEnergyCost() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamage TeleportDamageC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamage>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> TeleportDamage => TeleportDamageC.Value;

		public bool TryGetTeleportDamage(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamage component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportDamage()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamage() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportDamage(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamage() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageRadius TeleportDamageRadiusC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageRadius>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> TeleportDamageRadius => TeleportDamageRadiusC.Value;

		public bool TryGetTeleportDamageRadius(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageRadius component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportDamageRadius()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageRadius() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportDamageRadius(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageRadius() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageMask TeleportDamageMaskC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageMask>();

		public UnityEngine.LayerMask TeleportDamageMask => TeleportDamageMaskC.Value;

		public bool TryGetTeleportDamageMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddTeleportDamageMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Teleport.TeleportDamageMask() {Value = value}); 
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

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CurrentEnergy CurrentEnergyC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CurrentEnergy>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> CurrentEnergy => CurrentEnergyC.Value;

		public bool TryGetCurrentEnergy(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CurrentEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCurrentEnergy()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CurrentEnergy() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddCurrentEnergy(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CurrentEnergy() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.MaxEnergy MaxEnergyC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.MaxEnergy>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> MaxEnergy => MaxEnergyC.Value;

		public bool TryGetMaxEnergy(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.MaxEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddMaxEnergy()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.MaxEnergy() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddMaxEnergy(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.MaxEnergy() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CanUseEnergy CanUseEnergyC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CanUseEnergy>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanUseEnergy => CanUseEnergyC.Value;

		public bool TryGetCanUseEnergy(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CanUseEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCanUseEnergy(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CanUseEnergy() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyRequest UseEnergyRequestC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyRequest>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> UseEnergyRequest => UseEnergyRequestC.Value;

		public bool TryGetUseEnergyRequest(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddUseEnergyRequest()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyRequest() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddUseEnergyRequest(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyRequest() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyEvent UseEnergyEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> UseEnergyEvent => UseEnergyEventC.Value;

		public bool TryGetUseEnergyEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddUseEnergyEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddUseEnergyEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.UseEnergyEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CanRegenEnergy CanRegenEnergyC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CanRegenEnergy>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanRegenEnergy => CanRegenEnergyC.Value;

		public bool TryGetCanRegenEnergy(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CanRegenEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCanRegenEnergy(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.CanRegenEnergy() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyRequest RegenEnergyRequestC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyRequest>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> RegenEnergyRequest => RegenEnergyRequestC.Value;

		public bool TryGetRegenEnergyRequest(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyRequest component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddRegenEnergyRequest()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyRequest() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddRegenEnergyRequest(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyRequest() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyEvent RegenEnergyEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> RegenEnergyEvent => RegenEnergyEventC.Value;

		public bool TryGetRegenEnergyEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddRegenEnergyEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddRegenEnergyEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent<System.Int32> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.RegenEnergyEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.AutoRegenEnergyAmount AutoRegenEnergyAmountC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.AutoRegenEnergyAmount>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> AutoRegenEnergyAmount => AutoRegenEnergyAmountC.Value;

		public bool TryGetAutoRegenEnergyAmount(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.AutoRegenEnergyAmount component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddAutoRegenEnergyAmount()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.AutoRegenEnergyAmount() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddAutoRegenEnergyAmount(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Int32> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.AutoRegenEnergyAmount() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.IsAutoRegenEnergy IsAutoRegenEnergyC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.IsAutoRegenEnergy>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> IsAutoRegenEnergy => IsAutoRegenEnergyC.Value;

		public bool TryGetIsAutoRegenEnergy(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.IsAutoRegenEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsAutoRegenEnergy()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.IsAutoRegenEnergy() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddIsAutoRegenEnergy(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.IsAutoRegenEnergy() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenInitialTime EnergyAutoRegenInitialTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenInitialTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> EnergyAutoRegenInitialTime => EnergyAutoRegenInitialTimeC.Value;

		public bool TryGetEnergyAutoRegenInitialTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddEnergyAutoRegenInitialTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenInitialTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddEnergyAutoRegenInitialTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenInitialTime() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenCurrentTime EnergyAutoRegenCurrentTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenCurrentTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> EnergyAutoRegenCurrentTime => EnergyAutoRegenCurrentTimeC.Value;

		public bool TryGetEnergyAutoRegenCurrentTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddEnergyAutoRegenCurrentTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenCurrentTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddEnergyAutoRegenCurrentTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Energy.EnergyAutoRegenCurrentTime() {Value = value}); 
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

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InstantAttackDamage InstantAttackDamageC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InstantAttackDamage>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> InstantAttackDamage => InstantAttackDamageC.Value;

		public bool TryGetInstantAttackDamage(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InstantAttackDamage component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddInstantAttackDamage()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InstantAttackDamage() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddInstantAttackDamage(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InstantAttackDamage() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.ShootPoint ShootPointC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.ShootPoint>();

		public UnityEngine.Transform ShootPoint => ShootPointC.Value;

		public bool TryGetShootPoint(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.ShootPoint component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddShootPoint(UnityEngine.Transform value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.ShootPoint() {Value = value}); 
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

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.MustCancelAttack MustCancelAttackC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.MustCancelAttack>();

		public _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustCancelAttack => MustCancelAttackC.Value;

		public bool TryGetMustCancelAttack(out _Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.MustCancelAttack component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddMustCancelAttack(_Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.MustCancelAttack() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCanceledEvent AttackCanceledEventC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCanceledEvent>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent AttackCanceledEvent => AttackCanceledEventC.Value;

		public bool TryGetAttackCanceledEvent(out _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCanceledEvent component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackCanceledEvent()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCanceledEvent() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackCanceledEvent(_Project.Develop.Runtime.Utils.ReactiveManagement.Event.ReactiveEvent value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCanceledEvent() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownInitialTime AttackCooldownInitialTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownInitialTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> AttackCooldownInitialTime => AttackCooldownInitialTimeC.Value;

		public bool TryGetAttackCooldownInitialTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackCooldownInitialTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownInitialTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackCooldownInitialTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownInitialTime() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownCurrentTime AttackCooldownCurrentTimeC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownCurrentTime>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> AttackCooldownCurrentTime => AttackCooldownCurrentTimeC.Value;

		public bool TryGetAttackCooldownCurrentTime(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackCooldownCurrentTime()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownCurrentTime() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddAttackCooldownCurrentTime(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.AttackCooldownCurrentTime() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackCooldown InAttackCooldownC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackCooldown>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> InAttackCooldown => InAttackCooldownC.Value;

		public bool TryGetInAttackCooldown(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackCooldown component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddInAttackCooldown()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackCooldown() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddInAttackCooldown(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.Attack.InAttackCooldown() {Value = value}); 
		}

		public _Project.Develop.Runtime.Logic.Gameplay.Features.AI.CurrentTarget CurrentTargetC => GetComponent<_Project.Develop.Runtime.Logic.Gameplay.Features.AI.CurrentTarget>();

		public _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<_Project.Develop.Runtime.Entities.Entity> CurrentTarget => CurrentTargetC.Value;

		public bool TryGetCurrentTarget(out _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<_Project.Develop.Runtime.Entities.Entity> value)
		{
			bool result = TryGetComponent(out _Project.Develop.Runtime.Logic.Gameplay.Features.AI.CurrentTarget component);
			if(result)
				value = component.Value;
			else
				value = default(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<_Project.Develop.Runtime.Entities.Entity>);
			return result;
		}

		public _Project.Develop.Runtime.Entities.Entity AddCurrentTarget()
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.AI.CurrentTarget() { Value = new _Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<_Project.Develop.Runtime.Entities.Entity>() }); 
		}

		public _Project.Develop.Runtime.Entities.Entity AddCurrentTarget(_Project.Develop.Runtime.Utils.ReactiveManagement.ReactiveVariable<_Project.Develop.Runtime.Entities.Entity> value)
		{
			return AddComponent(new _Project.Develop.Runtime.Logic.Gameplay.Features.AI.CurrentTarget() {Value = value}); 
		}

	}
}
