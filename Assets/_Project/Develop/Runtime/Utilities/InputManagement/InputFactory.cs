using _Project.Develop.Runtime.Utils.InputManagement.Inputs;

namespace _Project.Develop.Runtime.Utils.InputManagement
{
    public class InputFactory
    {
        private UserInputAction _userInput = new();
        
        public PlayerInput CreatePlayerInput() => new(_userInput.Player);
        
        public UIInput CreateUIInput() => new(_userInput.UI);
    }
}