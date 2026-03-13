using _Project.Develop.Runtime.Configs.Gameplay.Entities;
using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI;
using _Project.Develop.Runtime.Utils.ReactiveManagement;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.ConfigsManagement;
using UnityEngine;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.MainHero
{
    public class MainHeroFactory
    { 
        private readonly EntitiesFactory _entitiesFactory;
        private readonly BrainsFactory _brainsFactory;
        private readonly ConfigsProviderService _configLoader;
        private readonly EntitiesLifeContext _entitiesLifeContext;

        public MainHeroFactory(DIContainer container)
        {
            _entitiesFactory = container.Resolve<EntitiesFactory>();
            _brainsFactory = container.Resolve<BrainsFactory>();
            _configLoader = container.Resolve<ConfigsProviderService>();
            _entitiesLifeContext = container.Resolve<EntitiesLifeContext>();
        }

        public Entity Create(Vector3 position)
        {
            HeroConfigSO config = _configLoader.GetConfig<HeroConfigSO>();

            Entity entity = _entitiesFactory.CreateHero(position, config);

            entity
                .AddIsMainHero()
                .AddTeam(new ReactiveVariable<Teams.Teams>(Teams.Teams.MainHero));

            entity.AddCurrentTarget();
            _brainsFactory.CreateMainHeroBrain(entity);

            _entitiesLifeContext.Add(entity);

            return entity;
        }
    }
}