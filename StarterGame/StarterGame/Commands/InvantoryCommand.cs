using System;
using System.Collections.Generic;
using System.Text;


namespace StarterGame.Commands
{
    //This is for the player to see the what they have in there invantory 
    public class InvantoryCommand : Command
    {
        public InvantoryCommand() : base()
        {
            this.name = "invantory";
        }
        public override bool execute(Player player)
        {

            if (this.hasSecondWord())
            {
                player.outputMessage("\n>.< wasn't able to find it" + this.secondWord);

            }
            return false;

        }
    }
}