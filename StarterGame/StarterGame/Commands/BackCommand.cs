using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    //This is the back command it part of the 5 things needed 
    public class BackCommand : Command
    {
        public BackCommand() : base()
        {
            this.name = "back";

        }
        public override bool execute(Characters.Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot backup " + this.secondWord);

            }
            return false;
        }
    }
}