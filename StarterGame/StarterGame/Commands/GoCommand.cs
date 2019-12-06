using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace StarterGame.Commands
{
    public class GoCommand : Command
    {
        //public TextWriter pathlog = new StreamWriter("C:\\PathLog.txt");

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
            }
            else
            {
                player.outputMessage("\nGo Where?");
            }
            return false;
        }
    }
}
