using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    //THis is to add combat into the game not sure if it is going to be used
    public class BuyCommand : Command
    {
        public BuyCommand() : base()
        {
            this.name = "Time";
        }
        public override bool execute(Characters.Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot quit " + this.secondWord);

            }
            return false;
        }
    }
}
