﻿using System;
using System.Collections.Generic;
using System.Text;
using StarterGame.Characters;

namespace StarterGame.Commands
{
    public class EquipCommand : Command
    {
        public EquipCommand() : base()
        {

                this.name = "equip";
        }

        public override bool execute(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
