using ConsoleEngine.Core.Location;
using ConsoleEngine.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Demo.Entities
{
    public class PackMan : ObjectBase
    {
        public ConsoleKey PressedKey { get; set; }

        public PackMan(int x, int y) : base(new Coordinates(x, y))
        {

        }

        private void Move()
        {
            var step = 1;

            switch (PressedKey)
            {
                case ConsoleKey.LeftArrow:
                    Coordinates = new Coordinates(Coordinates.X - step, Coordinates.Y);
                    break;
                case ConsoleKey.UpArrow:
                    Coordinates = new Coordinates(Coordinates.X, Coordinates.Y - step);
                    break;
                case ConsoleKey.RightArrow:
                    Coordinates = new Coordinates(Coordinates.X + step, Coordinates.Y);
                    break;
                case ConsoleKey.DownArrow:
                    Coordinates = new Coordinates(Coordinates.X, Coordinates.Y + step);
                    break;
                default:
                    break;
            }
        }

        public override void HandelInput(ConsoleKey input)
        {
            PressedKey = input;
            Move();
            PressedKey = 0;
        }
    }
}
