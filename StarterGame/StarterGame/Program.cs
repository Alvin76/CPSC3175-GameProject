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
            if (true) // see if there is a load then check to se if user want to load a save game
            {
                game.play(); // play Starts a new instance 
            }
            else //this is only if the user want to load a game. 
            {
                game.load(); // not implmeneted yet
            }
            game.end();
        }
    }
}
