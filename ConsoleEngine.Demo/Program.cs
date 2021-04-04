using ConsoleEngine.Core.Modules;
using ConsoleEngine.Demo.Entities;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleEngine.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;


            var pacman = new PackMan(5, 5);

            var scene = new Scene();
            scene.Initialize(new IGameObject[] { pacman });

            var game = new Game(scene);
            game.Load();


            var sw = new Stopwatch();
            var delay = 300;
            game.Loop((listener, scene) =>
            {
                //sw.Start();
                listener.Listen();
                game.HandelLogic();
                //sw.Stop();
                //var elapsed = sw.ElapsedMilliseconds;
                //var elapsed = new Random().Next(50, 150);

                //Log(elapsed.ToString());

                //sw.Reset();
                //var target = (elapsed > delay) ? 0 : delay - elapsed;
                //Console.WriteLine(target);
                //Log(target.ToString());
                scene.Render();


                //Task.Delay(TimeSpan.FromMilliseconds(target)).Wait();

                //Thread.Sleep(200);
            });
        }

        private static void Log(params string[] args)
        {
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();
            foreach (var item in args)
            {
                Console.Write(item + "\n");
            }
        }
    }
}