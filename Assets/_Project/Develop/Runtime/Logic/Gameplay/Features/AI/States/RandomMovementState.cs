using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States
{
    public class RandomMovementState : State, IUpdatableState
    {
        private ReactiveVariable<Vector3> _moveDirection;
        private ReactiveVariable<Vector3> _rotateDirection;

        private float _cooldownBetweenDirection;

        private float _time;


        public RandomMovementState(Entity entity, float cooldownBetweenDirection)
        {
            _moveDirection = entity.MoveDirection;
            _rotateDirection = entity.RotateDirection;

            _cooldownBetweenDirection = cooldownBetweenDirection;
        }

        public override void Enter()
        {
            base.Enter();

            Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
            _moveDirection.Value = randomDirection;
            _rotateDirection.Value = randomDirection;

            _time = 0;
        }

        public void Update(float deltaTime)
        {
            _time += deltaTime;

            if (_time >= _cooldownBetweenDirection)
            {
                Vector3 newDirection = GenerateNewDirection();
                
                _moveDirection.Value = newDirection;
                _rotateDirection.Value = newDirection;
                
                _time = 0;
            }
        }
        
        public override void Exit()
        {
            base.Exit();

            _moveDirection.Value = Vector3.zero;
        }
        
        private Vector3 GenerateNewDirection()
        {
            Vector3 inverseDirection = -_moveDirection.Value.normalized;
            Quaternion randomTurn = Quaternion.Euler(0, Random.Range(-30, 30), 0);
            
            return randomTurn * inverseDirection;
        }
    }
}