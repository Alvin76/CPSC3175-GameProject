using System;

namespace StarterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~Welcome Schuster dawn!~~~");
            Console.WriteLine("Make sure you attend class on time");
            Console.WriteLine("Do you have a game to load? y/n");
            /*
            var x = Console.Read();
            PathLoger logs = new PathLoger();
            if (x == 'n')
            {
                Console.WriteLine("setting up a new Game");
                logs.newGame();
            }
            else
            {
                Console.WriteLine("Loading up a new game");
                try
                {
                    logs.pathLoad();
                }
                catch
                {
                    Console.WriteLine("unable to load");
                    Console.WriteLine("Makeing a new game");
                    logs.newGame();
                }
            }
            */
            Game game = new Game();
            game.start();
            game.play(); // play Starts a new instance 
            game.end();
        }
    }
}
