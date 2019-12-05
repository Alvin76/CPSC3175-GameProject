using System;

namespace StarterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~Welcome Schuster dawn!~~~");
            Console.WriteLine("Make sure you attend class on time");
            Game game = new Game();
            game.start();
            game.play(); // play Starts a new instance 
            game.end();
        }
    }
}
