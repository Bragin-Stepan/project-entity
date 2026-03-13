using System;
using _Project.Develop.Runtime.Configs.Gameplay.Entities;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Enemies;
using _Project.Develop.Runtime.Logic.Gameplay.Features.MainHero;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Selectors;
using _Project.Develop.Runtime.Utils.InputManagement;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.AssetsManagement;
using Assets._Project.Develop.Runtime.Utilities.ConfigsManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features
{
    public class TestGameplay : MonoBehaviour
    {
        private DIContainer _container;
        private EnemiesFactory _enemiesFactory;
        private MainHeroFactory _mainHeroFactory;
        private BrainsFactory _brainsFactory;

        private Entity _hero;
        private Entity _enemy;
        
        private bool _isRunning;

        public void Initialize(DIContainer container)
        {
            _container = container;
            
            _container.Resolve<IPlayerInput>().Enable();

            _enemiesFactory = _container.Resolve<EnemiesFactory>();
            _mainHeroFactory = _container.Resolve<MainHeroFactory>();
            _brainsFactory = _container.Resolve<BrainsFactory>();

            _hero = _mainHeroFactory.Create(Vector3.zero);
            _enemy = _enemiesFactory.Create(
                Vector3.zero + Vector3.forward * 5,
                _container.Resolve<ConfigsProviderService>().GetConfig<WizardConfigSO>());
        }

        public void Run()
        {
            _isRunning = true;
        }

        private void Update()
        {
            if (_isRunning == false)
                return;
        }

        private void OnGUI()
        {
            if (_hero == null || _enemy == null)
                return;
            
            GUI.Label(new Rect(10, 20, 200, 50), $"Health: {_hero.CurrentHealth.Value}/{_hero.MaxHealth.Value}");
            GUI.Label(new Rect(10, 40, 200, 50), $"Energy: {_enemy.CurrentEnergy.Value}/{_enemy.MaxEnergy.Value}");
        }
    }
}