using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    //This is used for tradeing 
    public class TradeCommand : Command
    {
        public TradeCommand() : base()
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