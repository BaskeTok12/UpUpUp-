using Common.Common_Scripts.States;
using Player.Player_States;
using UnityEngine;

namespace Player.Scripts.Player_States
{
    public class FallState : BaseState
    {
        public FallState(PlayerController playerController) : base(playerController) { }
        
        public override void OnEnterState()
        {
            Debug.Log("Entered FallState!");
            
            _playerController.state = State.Fall;
        }
        
        public override void OnUpdateState()
        {
            
        }
    }
}