using System;
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

        private Entity _entity;
        private bool _isRunning;

        public void Initialize(DIContainer container)
        {
            _container = container;
            
            _container.Resolve<IPlayerInput>().Enable();
            _entitiesFactory = _container.Resolve<EntitiesFactory>();
        }

        public void Run()
        {
            _entity = _entitiesFactory.CreateTeleportWizard(Vector3.zero + Vector3.forward * 5);
            // _entitiesFactory.CreateHero(Vector3.zero);

            _isRunning = true;
        }

        private void Update()
        {
            if (_isRunning == false)
                return;
        }

        private void OnGUI()
        {
            if (_entity == null)
                return;
            
            GUI.Label(new Rect(10, 20, 200, 50), $"Energy: {_entity.CurrentEnergy.Value}/{_entity.MaxEnergy.Value}");
            // GUI.Label(new Rect(10, 40, 200, 50), $"CurrentEnergy: {_entity.CurrentEnergy.Value}");
            // GUI.Label(new Rect(10, 60, 200, 50), $"CurrentEnergy: {_entity.CurrentEnergy.Value}");
            // GUI.Label(new Rect(10, 80, 200, 50), $"CurrentEnergy: {_entity.CurrentEnergy.Value}");
            // GUI.Label(new Rect(10, 100, 200, 50), $"CurrentEnergy: {_entity.CurrentEnergy.Value}");
            // GUI.Label(new Rect(10, 120, 200, 50), $"CurrentEnergy: {_entity.CurrentEnergy.Value}");
        }
    }
}