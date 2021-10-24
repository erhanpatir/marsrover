using MarsRover.Controllers;
using MarsRover.CustomExceptions;
using Xunit;

namespace MarsRover.Tests
{
    public class ControllerTests
    {
        private const string Input = @"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";

        private const string Output = @"1 3 N
5 1 E";

        [Fact]
        public void Controller_Completed_Successfully()
        {
            IController controller = new MarsController();
            controller.GetCommands(Input);
            controller.InvokeCommands();
            Assert.Equal(Output, controller.Plateau.ToString());
        }

        [Fact]
        public void Controller_Throws_RoverCrashException()
        {
            const string command = @"5 5
1 2 N
LMLMLMLMM
3 3 W
MRMLLMRMLMRM";
            IController controller = new MarsController();
            controller.GetCommands(command);            
            Assert.Throws<RoverCrashException>(() => controller.InvokeCommands());
        }

        [Fact]
        public void Controller_Throws_RoverOutException()
        {
            const string command = @"5 5
1 2 N
LMLMLMLMM
3 3 W
MRRMMLMRMM";

            IController controller = new MarsController();
            controller.GetCommands(command);
            Assert.Throws<RoverOutException>(() =>controller.InvokeCommands());
        }
    }
}
