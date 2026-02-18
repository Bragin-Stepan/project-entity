using Assets._Project.Develop.Runtime.Utilities.SceneManagement;

namespace Assets._Project.Develop.Runtime.Gameplay.Infrastructure
{
    public class GameplayInputArgs : IInputSceneArgs
    {
        public int LevelNumber { get; }
        
        public GameplayInputArgs(int levelNumber)
        {
            LevelNumber = levelNumber;
        }
    }
}
