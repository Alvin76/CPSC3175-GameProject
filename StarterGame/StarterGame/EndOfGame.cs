using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using DotLiquid;

namespace StarterGame
{
    public class EndOfGame
    {
        private bool _VictoryCondition1;
        public bool VictoryCondition1
        {
            get => _VictoryCondition1;
            set => _VictoryCondition1 = value;
        }

        private bool _VictoryCondition2;

        public bool VictoryCondition2
        {
            get => _VictoryCondition2;
            set => _VictoryCondition2 = value;
        }

        public EndOfGame(bool victoryCondition1, bool victoryCondition2)
        {
            _VictoryCondition1 = victoryCondition1;
            _VictoryCondition2 = victoryCondition2;
        }

        public EndOfGame()
        {
        }

        public bool Win()
        {
            if (_VictoryCondition2 && VictoryCondition1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
