using System.Collections;
using System.Collections.Generic;

namespace StarterGame.Commands
{
    public class HelpCommand : Command
    {
        CommandWords words;

        public HelpCommand() : this(new CommandWords())
        {
        }

        public HelpCommand(CommandWords commands) : base()
        {
            words = commands;
            this.name = "help";
        }

        override
        public bool execute(Characters.Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot help you with " + this.secondWord);
            }
            else
            {
                player.outputMessage("\nYou are lost. You are alone. You wander around the university, \n\nYour available commands are " + words.description());
            }
            return false;
        }
    }
}
/*Help on comands 
 * Help     is used to find all comands that are avaible to be used
 * !!! Note should add sub comands to this
 * Go       is used to move room to room
 * Quit     is used to quit the program
 * Find     IS NOT IMPLMENETED YET
 * 
 * 
 */