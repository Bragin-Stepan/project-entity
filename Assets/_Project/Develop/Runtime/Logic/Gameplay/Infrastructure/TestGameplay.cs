using System;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI.States;
using _Project.Develop.Runtime.Utils.InputManagement;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features
{
    public class TestGameplay : MonoBehaviour
    {
        private DIContainer _container;
        private EntitiesFactory _entitiesFactory;
        private BrainsFactory _brainsFactory;

        private Entity _hero;
        private Entity _ghost;
        
        private bool _isRunning;

        public void Initialize(DIContainer container)
        {
            _container = container;
            
            _container.Resolve<IPlayerInput>().Enable();
            _entitiesFactory = _container.Resolve<EntitiesFactory>();
            _brainsFactory = _container.Resolve<BrainsFactory>();
        }

        public void Run()
        {
            _hero = _entitiesFactory.CreateHero(Vector3.zero);
            _hero.AddCurrentTarget();
            _brainsFactory.CreateMainHeroBrain(_hero, new NearestDamageableTargetSelector(_hero));
            
            _ghost = _entitiesFactory.CreateGhost(Vector3.zero + Vector3.forward * 5);
            _brainsFactory.CreateGhostBrain(_ghost);

            _isRunning = true;
        }

        private void Update()
        {
            if (_isRunning == false)
                return;
        }

        private void OnGUI()
        {
            if (_hero == null)
                return;
            
            GUI.Label(new Rect(10, 20, 200, 50), $"Health: {_hero.CurrentHealth.Value}/{_hero.MaxHealth.Value}");
            // GUI.Label(new Rect(10, 40, 200, 50), $"Energy: {_hero.CurrentEnergy.Value}/{_hero.MaxEnergy.Value}");
        }
    }
}