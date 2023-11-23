using Player.Scripts;
using Unity.VisualScripting;
using UnityEngine;
using State = Common.Common_Scripts.States.State;

namespace Player.Player_States
{
    public class IdleState : BaseState
    {
        public IdleState(PlayerController playerController) : base(playerController) { }
        
        public override void OnEnterState()
        {
            Debug.Log("Entered IdleState!");
            _playerController.SetState(State.Idle);
        }
        
        public override void OnUpdateState()
        {
            
        }
    }
}