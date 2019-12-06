using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    //This is for the find comamand this is used to see if there is any usable itemes in the room. 
    public class FindCommand : Command
    {
        public FindCommand() : base()
        {
            this.name = "find";
        }
        public override bool execute(Characters.Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\n >.< You tried, but wasn't able to find it" + this.secondWord);

            }
            else
            {
                player.outputMessage("\n You wheren't able to find anything");
            }
            return false;
        }
    }
}