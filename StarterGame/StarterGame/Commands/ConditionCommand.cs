using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    //This is to show the condition of the item selected 
    public class ConditionCommand : Command
    {
        public ConditionCommand() : base()
        {
            this.name = "Condition";
        }
        public override bool execute(Player player)
        {

            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot inspect" + this.secondWord);

            }
            return false;
        }
    }
}