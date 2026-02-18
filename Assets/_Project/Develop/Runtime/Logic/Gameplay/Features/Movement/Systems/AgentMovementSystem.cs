using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using UnityEngine;
using UnityEngine.AI;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Movement
{
    public class AgentMovementSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<float> _moveSpeed;
        private NavMeshAgent _agent;

        private Vector3 _position;

        public void OnInit(Entity entity)
        {
            _moveSpeed = entity.MoveSpeed;
            _agent = entity.NavMeshAgent;
            // _position получить позицию
            
            _agent.acceleration = 999;
        }

        public void OnUpdate(float deltaTime)
        {
            _agent.speed = _moveSpeed.Value;
            
            // _agent.SetDestination(_position);
        }
    }
}