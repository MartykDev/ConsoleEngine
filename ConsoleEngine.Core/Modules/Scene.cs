using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Core.Modules
{
    public class Scene
    {
        public IEnumerable<IGameObject> GameObjects { get; private set; }

        public void Initialize(IEnumerable<IGameObject> gameObjects)
        {
            GameObjects = gameObjects;
        }

        public void Render()
        {
            foreach (var gameObject in GameObjects)
            {
                gameObject.DrawObject();
            }
        }
    }
}