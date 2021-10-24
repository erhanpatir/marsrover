using MarsRover.Models;

namespace MarsRover.States
{
    internal class WestState : RoverState
    {
        public static readonly IState Instance = new WestState();
        private WestState( ) : base(West)
        {
        }

        public override void Move(Rover rover)
        {
            rover.SetPosition(rover.XCoordinate - 1, rover.YCoordinate);
        }

        public override void TurnLeft(Rover rover)
        {
            rover.State = SouthState.Instance;
        }

        public override void TurnRight(Rover rover)
        {
            rover.State = NorthState.Instance;
        }
    }
}
