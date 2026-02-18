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

	}
}
