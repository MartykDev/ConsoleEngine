using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Core.Modules
{
    public interface IGameObject
    {
        public void HandelInput(ConsoleKey input);
        public void DrawObject();
    }
}