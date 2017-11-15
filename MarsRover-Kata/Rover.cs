using System;

namespace MarsRover_Kata
{
    public class Rover
    {
        private int x;
        private int y;
        private string direction;

        public Rover(int x, int y, string direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        public override string ToString()
        {
            return $"{x},{y},{direction}";
        }

        public void MoveForward()
        {
            switch (direction)
            {
                case "N":
                    y++; break;

                case "S":
                    y--; break;

                case "E":
                    x++; break;

                case "W":
                    x--; break;
            }
        }
    }
}
