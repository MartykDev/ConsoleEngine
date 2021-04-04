using System;

namespace ConsoleEngine.Core.Modules
{
    public class Game
    {
        private Scene _gameScene;
        private KeystrokeListener _keystrokeListener;

        private bool loopIsRun;
        private ConsoleKey input;

        public Game(Scene gameScene)
        {
            _gameScene = gameScene;
            _keystrokeListener = new KeystrokeListener();
        }

        public void Load()
        {
            loopIsRun = true;
            _keystrokeListener.OnPressKey += (key) => input = key;
        }

        public void HandelLogic()
        {
            foreach (var gameObject in _gameScene.GameObjects)
            {
                gameObject.HandelInput(input);
            }
            input = 0;
        }

        public void Loop(Action<KeystrokeListener, Scene> logic)
        {
            while (loopIsRun)
            {
                logic.Invoke(_keystrokeListener, _gameScene);
            }
        }

        public void BreakGameLoop()
        {
            loopIsRun = !loopIsRun;
        }
    }
}