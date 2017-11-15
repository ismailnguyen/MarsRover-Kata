using NFluent;
using NUnit.Framework;

namespace MarsRover_Kata.Tests
{
    public class RoverTest
    {
        [TestCase(0, 0, Direction.North, "0,0,North")]
        [TestCase(0, 0, Direction.South, "0,0,South")]
        [TestCase(0, 0, Direction.East, "0,0,East")]
        [TestCase(0, 0, Direction.West, "0,0,West")]
        public void Should_Rover_Land_Correctly(int x, int y, Direction direction, string expectedPosition)
        {
            // GIVEN
            Rover rover = new Rover(x, y, direction);

            // WHEN
            string roverPosition = rover.ToString();

            // THEN
            Check.That(roverPosition).IsEqualTo(expectedPosition);
        }

        [TestCase(0, 0, Direction.North, "0,1,North")]
        [TestCase(0, 0, Direction.South, "0,-1,South")]
        [TestCase(0, 0, Direction.East, "1,0,East")]
        [TestCase(0, 0, Direction.West, "-1,0,West")]
        public void Should_Rover_Move_Forward(int x, int y, Direction direction, string expectedPosition)
        {
            // GIVEN
            Rover rover = new Rover(x, y, direction);

            // WHEN
            rover.MoveForward();

            // THEN
            Check.That(rover.ToString()).IsEqualTo(expectedPosition);
        }

        [TestCase(0, 0, Direction.North, "0,1,North")]
        [TestCase(0, 0, Direction.South, "0,-1,South")]
        [TestCase(0, 0, Direction.East, "1,0,East")]
        [TestCase(0, 0, Direction.West, "-1,0,West")]
        public void Should_Rover_Move_Backward(int x, int y, Direction direction, string expectedPosition)
        {
            // GIVEN
            Rover rover = new Rover(x, y, direction);

            // WHEN
            rover.MoveBackward();

            // THEN
            Check.That(rover.ToString()).IsEqualTo(expectedPosition);
        }
    }
}
