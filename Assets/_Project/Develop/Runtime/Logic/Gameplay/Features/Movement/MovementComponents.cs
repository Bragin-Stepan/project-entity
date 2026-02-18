using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class MoveDirection : IEntityComponent { public ReactiveVariable<Vector3> Value; }
    public class MoveSpeed : IEntityComponent { public ReactiveVariable<float> Value; }
    
    public class RotateDirection : IEntityComponent { public ReactiveVariable<Vector3> Value; }
    public class RotationSpeed : IEntityComponent { public ReactiveVariable<float> Value; }
    
    public class JumpForce : IEntityComponent { public ReactiveVariable<float> Value; }
}