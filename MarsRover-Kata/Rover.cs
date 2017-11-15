using System;

namespace MarsRover_Kata
{
    public class Rover
    {
        private int x;
        private int y;
        private Direction Direction;

        public Rover(int x, int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            Direction = direction;
        }

        public override string ToString()
        {
            return $"{x},{y},{Direction}";
        }

        public void MoveForward()
        {
            switch (Direction)
            {
                case Direction.North:
                    y++; break;

                case Direction.South:
                    y--; break;

                case Direction.East:
                    x++; break;

                case Direction.West:
                    x--; break;
            }
        }

        public void MoveBackward()
        {
            switch (Direction)
            {
                case Direction.North:
                    y--; break;

                case Direction.South:
                    y++; break;

                case Direction.East:
                    x--; break;

                case Direction.West:
                    x++; break;
            }
        }
    }
}
