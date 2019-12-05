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
            this.name = "attack";
        }
        public override bool execute(Characters.Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI backup quit " + this.secondWord);

            }
            return false;
        }
    }
}