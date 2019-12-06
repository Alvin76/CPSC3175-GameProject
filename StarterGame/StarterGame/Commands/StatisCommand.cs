using System;
using System.Collections.Generic;
using System.Text;


namespace StarterGame.Commands
{
    //THis is to add combat into the game not sure if it is going to be used
    public class StatisCommand : Command
    {
        public StatisCommand() : base()
        {
            this.name = "Statis";
        }
        public override bool execute(Characters.Player player)
        {

            if (this.hasSecondWord())
            {
                player.outputMessage("\nKeep calm and carry on" + this.secondWord);

            }
            return false;
        }
    }
}