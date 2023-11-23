using Player.Scripts;

namespace Player.Player_States
{
    public abstract class BaseState : IState
    {
        protected PlayerController _playerController;
        
        public BaseState(PlayerController playerController)
        {
            _playerController = playerController;
        }
        
        public abstract void OnEnterState();
        public abstract void OnUpdateState();
    }
}