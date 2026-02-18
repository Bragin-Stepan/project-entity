using System.Collections.Generic;
using UnityEngine;

namespace _Project.Develop.Runtime.Configs.Gameplay.Levels
{
    [CreateAssetMenu(menuName = "Configs/Gameplay/Levels/LevelsListConfig", fileName = "LevelsListConfig")]
    public class LevelsListConfigSO : ScriptableObject
    {
        [SerializeField] private List<LevelConfigSO> _levels;

        public IReadOnlyList<LevelConfigSO> Levels => _levels;

        public LevelConfigSO GetBy(int levelNumber)
        {
            int levelIndex = levelNumber - 1;

            return _levels[levelIndex];
        }
    }
}