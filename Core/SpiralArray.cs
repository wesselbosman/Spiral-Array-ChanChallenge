using System;
using System.Text;

namespace Core
{
    public class SpiralArray
    {
        private readonly int[,] _array;
        private Direction _direction;

        public SpiralArray(int n, int m)
        {
            _array = new int[n, m];

            var maximum = m * n;
            var columnMax = m;
            var rowMax = n;
            var loops = 0;

            _direction = Direction.East;

            for (int x = 0, y = 0, count = 1; count <= maximum; count++)
            {
                if (_direction == Direction.East)
                {
                    if (x == columnMax - loops)
                    {
                        ChangeDirection90Degrees();
                        count--;
                        x--;
                        y++;
                        continue;
                    }

                    _array[y, x] = count;
                    x++;
                }

                if (_direction == Direction.South)
                {
                    if (y == rowMax - loops)
                    {
                        ChangeDirection90Degrees();
                        count--;
                        y--;
                        x--;
                        continue;
                    }

                    _array[y, x] = count;
                    y++;
                }

                if (_direction == Direction.West)
                {
                    if (x == loops - 1)
                    {
                        ChangeDirection90Degrees();
                        count--;
                        y--;
                        x++;
                        continue;
                    }

                    _array[y, x] = count;
                    x--;
                }

                if (_direction == Direction.North)
                {
                    if (y == loops)
                    {
                        ChangeDirection90Degrees();
                        count--;
                        x++;
                        y++;
                        loops++;
                        continue;
                    }

                    _array[y, x] = count;
                    y--;
                }

            }
        }

        private void ChangeDirection90Degrees()
        {
            switch (_direction)
            {
                case Direction.East:
                    _direction = Direction.South;
                    break;
                case Direction.North:
                    _direction = Direction.East;
                    break;
                case Direction.South:
                    _direction = Direction.West;
                    break;
                case Direction.West:
                    _direction = Direction.North;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int[,] Value()
        {
            return _array;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            var rowLength = _array.GetLength(0);
            var colLength = _array.GetLength(1);

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    stringBuilder.Append(string.Format("{0} ", _array[i, j]));
                }
                stringBuilder.Append(Environment.NewLine + Environment.NewLine);
            }

            return stringBuilder.ToString();
        }
    }

    internal enum Direction
    {
        North,
        South,
        East,
        West
    }
}