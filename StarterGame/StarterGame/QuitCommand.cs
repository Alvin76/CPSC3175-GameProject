using System;
using System.Collections;
using System.Collections.Generic;

namespace StarterGame
{
    public class QuitCommand : Command
    {

        public QuitCommand() : base()
        {
            this.name = "quit";
        }

        override
        public bool execute(Player player)
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

namespace StarterGame
{
    //This is for the find comamand this is used to see if there is any usable itemes in the room. 
    public class FindCommand : Command
    {
        public FindCommand() : base()
        {
            this.name = "find";
        }
        public override bool execute(Player player)
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
namespace StarterGame
{
    //THis is to add combat into the game not sure if it is going to be used
    public class AttackCommand : Command
    {
        public AttackCommand() : base()
        {
            this.name = "attack";
        }
        public override bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot quit " + this.secondWord);
                
            }
            return false;
        }
    }
}
namespace StarterGame
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
namespace StarterGame
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
namespace StarterGame
{
    //THis is to add combat into the game not sure if it is going to be used
    public class StatisCommand : Command
    {
        public StatisCommand() : base()
        {
            this.name = "Statis";
        }
        public override bool execute(Player player)
        {
            
            if (this.hasSecondWord())
            {
                player.outputMessage("\nKeep calm and carry on" + this.secondWord);
                
            }
            return false;
        }
    }
}