﻿using state.Abstractions;

namespace state
{
    public class Context
    {
        private IState currentState;

        public Context()
        {
            currentState = new StateA();
        }

        public void ChangeState(IState newState)
        {
            currentState = newState;
        }

        public void Request()
        {
            currentState.Handle(this);
        }
    }
}
