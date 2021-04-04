using ConsoleEngine.Core.Enums;
using ConsoleEngine.Core.Location;
using ConsoleEngine.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Core.Objects
{
    public abstract class ObjectBase : IGameObject
    {
        private Coordinates _oldCoordinates;
        private Coordinates _currentCoordinates;

        public Coordinates Coordinates 
        {
            get { return _currentCoordinates; }
            
            protected set
            {
                _oldCoordinates = _currentCoordinates;
                _currentCoordinates = value;
            }
        }
        public Direction Direction { get; protected set; }

        public ObjectBase(Coordinates coordinates)
        {
            Coordinates = coordinates;
        }

        public virtual void DrawObject()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(_currentCoordinates.X, _currentCoordinates.Y);
            Console.Write(" ");
            Console.ResetColor();

            //Erase old draw
            Console.SetCursorPosition(_oldCoordinates.X, _oldCoordinates.Y);
            Console.Write(" ");
        }

        public virtual void HandelInput(ConsoleKey input)
        {

        }
    }
}
