using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    public class LoadCommand : Command
    {
        public LoadCommand() : base()
        {
            this.name = "load";
        }
        public override bool execute(Characters.Player player)
        {
            throw new NotImplementedException();
        }
    }
}
