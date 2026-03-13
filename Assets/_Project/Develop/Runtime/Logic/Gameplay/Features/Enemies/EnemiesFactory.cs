using System;
using _Project.Develop.Runtime.Configs.Gameplay.Entities;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Selectors;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Enemies
{
    public class EnemiesFactory
    {
        private readonly EntitiesFactory _entitiesFactory;
        private readonly BrainsFactory _brainsFactory;
        private readonly EntitiesLifeContext _entitiesLifeContext;

        public EnemiesFactory(DIContainer container)
        {
            _entitiesFactory = container.Resolve<EntitiesFactory>();
            _brainsFactory = container.Resolve<BrainsFactory>();
            _entitiesLifeContext = container.Resolve<EntitiesLifeContext>();
        }

        public Entity Create(Vector3 position, EntityConfigSO config)
        {
            Entity entity;

            switch (config)
            {
                case GhostConfigSO ghostConfig:
                    entity = _entitiesFactory.CreateGhost(position, ghostConfig);
                    _brainsFactory.CreateGhostBrain(entity);
                    break;
                
                case WizardConfigSO wizardConfig:
                    entity = _entitiesFactory.CreateTeleportWizard(position, wizardConfig);
                    _brainsFactory.CreateDangerWizardBrain(entity, new LowestHealthTargetSelector(entity));
                    break;

                default:
                    throw new ArgumentException($"Not support {config.GetType()} type config");
            }
            
            entity.AddTeam(new ReactiveVariable<Teams.Teams>(Teams.Teams.Enemies));
            
            _entitiesLifeContext.Add(entity);

            return entity;
        }
    }
}