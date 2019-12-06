using System;
using System.Collections.Generic;
using System.Text;
using StarterGame.Characters;

namespace StarterGame.Commands
{
    //THis is to add combat into the game not sure if it is going to be used
    public class TimeCommand : Command
    {
        public override bool execute(Characters.Player player)
        {

            if (this.hasThirdWord())
            {
                player.outputMessage("\nI cannot quit " + this.thirdWord);

            }
            else if (this.hasSecondWord())
            {
                player.outputMessage("\nI do not understand " + this.secondWord);
            }
            else
            {
                player.outputMessage("\nyou have this much " + _Time + "time left");
            }
            return false;
        }
    }
}