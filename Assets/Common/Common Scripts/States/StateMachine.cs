using System.Collections;
using System.Collections.Generic;
using Player.Player_States;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private IState _state;

    public void SetState(IState state)
    {
        if (_state != null)
        {
            var previousState = _state;

            if (previousState != state)
            {
                state.OnEnterState();
            }
        }
        else
        {
            state.OnEnterState();
        }

        _state = state;
    }

    public void UpdateStateMachine()
    {
        if (_state != null)
        {
            _state.OnUpdateState();
        }
    }
}
