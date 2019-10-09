using System;

namespace StarterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Etius State Uneversity Simpulation!");
            Game game = new Game();
            game.start();
            game.play();
            game.end();
        }
    }
}
