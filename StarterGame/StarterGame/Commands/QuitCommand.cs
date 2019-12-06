using System;
using System.Collections;
using System.Collections.Generic;

namespace StarterGame.Commands
{
    public class QuitCommand : Command
    {

        public QuitCommand() : base()
        {
            this.name = "quit";
        }

        override
        public bool execute(Characters.Player player)
        {
            bool answer = true;
            if (this.hasThirdWord())
            {
                player.outputMessage("\nI cannot quit " + this.secondWord + ' ' + this.thirdWord);
                answer = false;
            }
            else if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot quit " + this.secondWord);
                answer = false;
            }

            return answer; // if the bool = true the program quits
        }

    }
}
// @R We are can add more comands here and brake them out when needed 
// @R still looking where i can add a stroy section                     
