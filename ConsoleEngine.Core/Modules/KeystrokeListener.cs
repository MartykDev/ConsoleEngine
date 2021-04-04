using System;

namespace ConsoleEngine.Core.Modules
{
    public class KeystrokeListener
    {
        public Action<ConsoleKey> OnPressKey { get; set; }

        public void Listen()
        {
            if (Console.KeyAvailable)
            {
                var k = Console.ReadKey(true).Key;
                OnPressKey?.Invoke(k);
            }
        }
    }
}