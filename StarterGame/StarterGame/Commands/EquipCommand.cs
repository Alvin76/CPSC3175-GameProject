using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Commands
{
    public class EquipCommand : Command
    {
        public EquipCommand() : base()
        {
            if (_Time < 720)
            {
                this.name = "equip";
                this._Time = +5;
            }
        }
        public override bool execute(Characters.Player player)
        {
            throw new NotImplementedException();
        }
    }
}
