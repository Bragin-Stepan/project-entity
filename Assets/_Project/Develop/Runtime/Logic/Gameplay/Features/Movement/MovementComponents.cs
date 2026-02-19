using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class MoveDirection : IEntityComponent { public ReactiveVariable<Vector3> Value; }
    public class MoveSpeed : IEntityComponent { public ReactiveVariable<float> Value; }
    public class IsMoving : IEntityComponent { public ReactiveVariable<bool> Value; }
    public class CanMove : IEntityComponent { public ICompositeCondition Value; }

    public class RotateDirection : IEntityComponent { public ReactiveVariable<Vector3> Value; }
    public class RotationSpeed : IEntityComponent { public ReactiveVariable<float> Value; }
    public class CanRotate : IEntityComponent { public ICompositeCondition Value; }
    
    public class JumpForce : IEntityComponent { public ReactiveVariable<float> Value; }
    public class CanJump : IEntityComponent { public ICompositeCondition Value; }
    
}