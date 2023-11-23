

namespace Player.Player_States
{
    public interface IState
    {
        public abstract void OnEnterState();
        public abstract void OnUpdateState();
    }
}