using System;
using System.Collections.Generic;
using _Project.Develop.Runtime.Utilities.Conditions;
using _Project.Develop.Runtime.Utils.InputManagement.States;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace _Project.Develop.Runtime.Utils.InputManagement
{
    public class InputStateMachine : StateMachine<IState>, IInitializable, IDisposable
    {
        private readonly IPlayerInput _playerInput;
        private readonly IUIInput _uiInput;
        
        public InputStateMachine(List<IDisposable> disposables) : base(disposables)
        { }
        
        public InputStateMachine(DIContainer container) : base(new List<IDisposable>())
        {
            _playerInput = container.Resolve<IPlayerInput>();
            _uiInput = container.Resolve<IUIInput>();
        }
        
        public void Initialize()
        {
            PlayerInputState playerInputState = new(_playerInput);
            UIInputState uiInputState = new(_uiInput);
            
            ICompositeCondition playerToUiStateCondition = new CompositeCondition(LogicOperationsUtils.Or)
                .Add(new FuncCondition(() => _uiInput.IsEnabled));
                // .Add(new FuncCondition(() => _playerHorseInput.IsEnabled));

            ICompositeCondition uiToPlayerStateCondition = new CompositeCondition(LogicOperationsUtils.Or)
                .Add(new FuncCondition(() => _playerInput.IsEnabled));
                // .Add(new FuncCondition(() => _playerHorseInput.IsEnabled));
            
            AddState(playerInputState); 
            AddState(uiInputState);
            
            AddTransition(playerInputState, uiInputState, playerToUiStateCondition);
            AddTransition(uiInputState, playerInputState, uiToPlayerStateCondition);
            
            Enter();
        }

        public void Dispose()
        {
            Exit();
        }
    }
}