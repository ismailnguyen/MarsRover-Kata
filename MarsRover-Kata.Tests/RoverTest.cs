using NFluent;
using NUnit.Framework;

namespace MarsRover_Kata.Tests
{
    public class RoverTest
    {
        [TestCase(0, 0, "N", "0,0,N")]
        [TestCase(0, 0, "S", "0,0,S")]
        [TestCase(0, 0, "E", "0,0,E")]
        [TestCase(0, 0, "W", "0,0,W")]
        public void Should_Rover_Land_Correctly(int x, int y, string direction, string expectedPosition)
        {
            // GIVEN
            Rover rover = new Rover(x, y, direction);

            // WHEN
            string roverPosition = rover.ToString();

            // THEN
            Check.That(roverPosition).IsEqualTo(expectedPosition);
        }
    }
}
