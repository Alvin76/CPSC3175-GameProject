using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    public class SaveCommand : Command
    {
        public SaveCommand() : base()
        {
            this.name = "save";
        }
        public override bool execute(Characters.Player player)
        {
            throw new NotImplementedException();
        }
    }
}