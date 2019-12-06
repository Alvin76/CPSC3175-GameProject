using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

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
                string[] X =new string[1];
                X[0] = this.secondWord;
                File.AppendAllLines("PathLog.txt", X);
                
            }
            else
            {
                player.outputMessage("\nGo Where?");
            }
            return false;
        }
    }
}
