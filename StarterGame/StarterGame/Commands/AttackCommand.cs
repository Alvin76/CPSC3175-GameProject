using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    //THis is to add combat into the game not sure if it is going to be used
    public class AttackCommand : Command
    {
        public AttackCommand() : base()
        {
            if(_Time < 720)
            {
                this.name = "attack";
                this._Time = +10;
            }
            else
            {
                EndOfGame();
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