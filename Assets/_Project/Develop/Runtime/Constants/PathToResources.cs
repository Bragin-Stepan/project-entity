using System;
using System.Collections.Generic;
using _Project.Develop.Runtime.Configs.Meta;
using _Project.Develop.Runtime.UI.Common;
using _Project.Develop.Runtime.UI.Features.LevelsMenuPopup;
using _Project.Develop.Runtime.UI.Screens.Gameplay;
using _Project.Develop.Runtime.UI.Screens.MainMenu;

namespace Assets._Project.Develop.Runtime.Utilities.SceneManagement
{
    public static class PathToResources
    {
        public static IReadOnlyDictionary<Type, string> ScriptableObject => _scriptableObject;
        public static IReadOnlyDictionary<Type, string> UIPaths => _uiPaths;
        
        public static class Util
        {
            public const string Coroutine = "Utilities/CoroutinesPerformer";
        }
        
        public static class UI
        {
            public static class LoadingScreen
            {
                public const string Standard = "Utilities/StandardLoadingScreen";
            }
            
            public static class Screens
            {
                public const string MainMenu = "UI/Screens/MainMenu/MainMenuUIRoot";
                public const string Gameplay = "UI/Screens/Gameplay/GameplayUIRoot";
            }
        }
        
        public static class Entity
        {
            public const string TestEntity = "Entities/TestEntity";
        }
        
        private static readonly Dictionary<Type, string> _scriptableObject = new()
        {
            { typeof(StartWalletConfigSO), "Configs/Meta/Wallet/StartWalletConfig" },
            { typeof(CurrencyIconsConfigSO), "Configs/Meta/Wallet/CurrencyIconsConfig" },
        };
        
        private static readonly Dictionary<Type, string> _uiPaths = new()
        {
            {typeof(MainMenuScreenView), "UI/Screens/MainMenu/MainMenuScreenView" },
            {typeof(GameplayScreenView), "UI/Screens/Gameplay/GameplayScreenView" },
            
            {typeof(IconTextView), "UI/Common/IconTextView" },
            
            {typeof(LevelTileView), "UI/LevelsMenuPopup/LevelTile" },
            {typeof(LevelsMenuPopupView), "UI/LevelsMenuPopup/LevelsMenuPopup" },
        };
    }
}