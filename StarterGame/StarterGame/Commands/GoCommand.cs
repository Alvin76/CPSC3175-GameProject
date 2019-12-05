using System.Collections;
using System.Collections.Generic;

namespace StarterGame.Commands
{
    public class GoCommand : Command
    {

        public GoCommand() : base()
        {
            this.name = "go";
        }

        override
        public bool execute(Characters.Player player)
        {
            if (this.hasSecondWord())
            {
                player.waltTo(this.secondWord);
            }
            else
            {
                player.outputMessage("\nGo Where?");
            }
            return false;
        }
    }
}
