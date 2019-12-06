using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    //Buying and selling comback to it
    public class BuyCommand : Command
    {
        public BuyCommand() : base()
        {
            if (_Time < 720)
            {
                this.name = "buy";
            }
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
