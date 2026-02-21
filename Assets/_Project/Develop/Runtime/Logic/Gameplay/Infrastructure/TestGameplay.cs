using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utils.InputManagement;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features
{
    public class TestGameplay : MonoBehaviour
    {
        private DIContainer _container;
        private EntitiesFactory _entitiesFactory;

        private bool _isRunning;

        public void Initialize(DIContainer container)
        {
            _container = container;
            
            _container.Resolve<IPlayerInput>().Enable();
            _entitiesFactory = _container.Resolve<EntitiesFactory>();
        }

        public void Run()
        {
            _entitiesFactory.CreateMage(Vector3.zero + Vector3.forward * 5);
            _entitiesFactory.CreateHero(Vector3.zero);

            _isRunning = true;
        }

        private void Update()
        {
            if (_isRunning == false)
                return;
        }
    }
}