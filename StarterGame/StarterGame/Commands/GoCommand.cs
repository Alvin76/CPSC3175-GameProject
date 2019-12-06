using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace StarterGame.Commands
{
    public class GoCommand : Command
    {


        public GoCommand() : base()
        {
            this.name = "go";
        }

        override
        public bool execute(Characters.Player player)
        {
            if (this.hasSecondWord())
            {
                player.waltTo(this.secondWord);
<<<<<<< HEAD
=======
                /*
                try
                {

                    pathlog.WriteLine(this.name + this.secondWord);
                    pathlog.Close();
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("SYSTEM FAILURE CONTACT ");
                }*/
>>>>>>> 20b3e5a58971bb51ed2997462fdb111c9443fb22
            }
            else
            {
                player.outputMessage("\nGo Where?");
            }
            return false;
        }
    }
}
