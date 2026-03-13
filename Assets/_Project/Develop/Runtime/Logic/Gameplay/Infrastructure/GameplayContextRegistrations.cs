using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Logic.Gameplay.Features.AI;
using _Project.Develop.Runtime.Logic.Gameplay.Features.Enemies;
using _Project.Develop.Runtime.Logic.Gameplay.Features.MainHero;
using _Project.Develop.Runtime.UI;
using _Project.Develop.Runtime.UI.Core;
using _Project.Develop.Runtime.UI.Screens.Gameplay;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.AssetsManagement;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Gameplay.Infrastructure
{
    public class GameplayContextRegistrations
    {
        public static void Process(DIContainer container)
        {
            // container.RegisterAsSingle(CreateGameplayUIRoot).NonLazy();
            // container.RegisterAsSingle(CreateGameplayScreenPresenter).NonLazy();
            // container.RegisterAsSingle(CreateGameplayPresentersFactory);
            // container.RegisterAsSingle(CreateGameplayPopupService);
            
            container.RegisterAsSingle(CreateEntitiesFactory);
            container.RegisterAsSingle(CreateEntitiesLifeContext);
            container.RegisterAsSingle(CreateCollidersRegistryService);
            container.RegisterAsSingle(CreateAIBrainContext);
            container.RegisterAsSingle(CreateBrainsFactory);
            container.RegisterAsSingle(CreateMonoEntitiesFactory).NonLazy();
            container.RegisterAsSingle(CreateMainHeroFactory);
            container.RegisterAsSingle(CreateEnemiesFactory);
        }
        
        private static AIBrainsContext CreateAIBrainContext(DIContainer c) => new();
        private static BrainsFactory CreateBrainsFactory(DIContainer c) => new(c);
        private static EntitiesLifeContext CreateEntitiesLifeContext(DIContainer c) => new();

        private static EnemiesFactory CreateEnemiesFactory(DIContainer c) => new (c);
        private static MainHeroFactory CreateMainHeroFactory(DIContainer c) => new (c);

        private static EntitiesFactory CreateEntitiesFactory(DIContainer c) => new(c);
        
        private static GameplayPresentersFactory CreateGameplayPresentersFactory(DIContainer c) => new(c);

        private static CollidersRegistryService CreateCollidersRegistryService(DIContainer c) => new();

        private static GameplayPopupService CreateGameplayPopupService(DIContainer c)
        {
            return new GameplayPopupService(
                c.Resolve<ViewsFactory>(),
                c.Resolve<ProjectPresentersFactory>(),
                c.Resolve<GameplayUIRoot>(),
                c.Resolve<GameplayPresentersFactory>());
        }

        private static GameplayUIRoot CreateGameplayUIRoot(DIContainer c)
        {
            ResourcesAssetsLoader loader = c.Resolve<ResourcesAssetsLoader>();
            GameplayUIRoot uiRootPrefab = loader.Load<GameplayUIRoot>(PathToResources.UI.Screens.Gameplay);

            return Object.Instantiate(uiRootPrefab);
        }

        private static GameplayScreenPresenter CreateGameplayScreenPresenter(DIContainer c)
        {
            GameplayUIRoot uiRoot = c.Resolve<GameplayUIRoot>();
            GameplayScreenView view = c.Resolve<ViewsFactory>().Create<GameplayScreenView>(uiRoot.HUDLayer);
            
            return c.Resolve<GameplayPresentersFactory>().CreateGameplayScreenPresenter(view);
        }
        
        private static MonoEntitiesFactory CreateMonoEntitiesFactory(DIContainer c)
        {
            return new MonoEntitiesFactory(
                c.Resolve<ResourcesAssetsLoader>(),
                c.Resolve<EntitiesLifeContext>(),
                c.Resolve<CollidersRegistryService>());
        }
    }
}
