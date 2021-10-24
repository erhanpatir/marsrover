using MarsRover.Models;

namespace MarsRover.States
{
    internal class EastState : RoverState
    {
        public static readonly IState Instance = new EastState();
        private EastState() : base(East)
        {
        }

        public override void Move(Rover rover)
        {
            rover.SetPosition(rover.XCoordinate + 1, rover.YCoordinate);
        }

        public override void TurnLeft(Rover rover)
        {
            rover.State = NorthState.Instance;
        }

        public override void TurnRight(Rover rover)
        {
            rover.State = SouthState.Instance;
        }
    }
}
