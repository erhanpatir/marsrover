using MarsRover.Models;

namespace MarsRover.States
{
    internal class SouthState : RoverState
    {
        public static readonly IState Instance = new SouthState();
        private SouthState() : base(South)
        {
        }

        public override void Move(Rover rover)
        {
            rover.SetPosition(rover.XCoordinate, rover.YCoordinate - 1);
        }

        public override void TurnLeft(Rover rover)
        {
            rover.State = EastState.Instance;
        }

        public override void TurnRight(Rover rover)
        {
            rover.State = WestState.Instance;
        }
    }
}
