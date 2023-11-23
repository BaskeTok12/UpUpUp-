using Common.Common_Scripts.States;
using Player.Player_States;
using UnityEngine;

namespace Player.Scripts.Player_States
{
    public class RunState : BaseState, IState
    {
        public RunState(PlayerController playerController) : base(playerController) { }
        
        public override void OnEnterState()
        {
            Debug.Log("Entered RunState!");
            
            _playerController.SetSpeed(_playerController.runSpeed);
            _playerController.state = State.Run;
        }
        
        public override void OnUpdateState()
        {
            
        }
    }
}