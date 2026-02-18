using _Project.Develop.Runtime.UI.Core;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;

namespace _Project.Develop.Runtime.UI.Features.LevelsMenuPopup
{
    public class LevelTilePresenter : ISubscribedPresenter
    {
        private readonly SceneSwitcherService _sceneSwitcherService;

        private readonly LevelTileView _view;

        public LevelTilePresenter(
            SceneSwitcherService sceneSwitcherService, 
            LevelTileView view)
        {
            _sceneSwitcherService = sceneSwitcherService;
            _view = view;
        }

        public LevelTileView View => _view;

        public void Initialize()
        {
            // _view.SetLevel(_gameMode.ToString());
            _view.SetActive();
        }

        public void Dispose()
        {
            _view.Clicked -= OnViewClicked;
        }

        public void Subscribe()
        {
            _view.Clicked += OnViewClicked;
        }

        public void Unsubscribe()
        {
            _view.Clicked -= OnViewClicked;
        }

        private void OnViewClicked()
        {
            // _gameRunner.Run(_gameMode);
        }
    }
}
