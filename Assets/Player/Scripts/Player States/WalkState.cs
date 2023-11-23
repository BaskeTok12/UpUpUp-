using Common.Common_Scripts.States;
using Player.Scripts;
using UnityEngine;

namespace Player.Player_States
{
    public class WalkState : BaseState
    {
        public WalkState(PlayerController playerController) : base(playerController) { }
        
        public override void OnEnterState()
        {
            Debug.Log("Entered WalkState!");
            
            _playerController.SetSpeed(_playerController.walkSpeed);
            _playerController.state = State.Walk;
        }
        
        public override void OnUpdateState()
        {
            
        }
    }
}