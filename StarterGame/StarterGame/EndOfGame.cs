using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using DotLiquid;

namespace StarterGame
{
    public class EndOfGame
    {
        private static EndOfGame clearGame = null;
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

        private EndOfGame()
        {
            VictoryCondition1 = false;
            VictoryCondition2 = false;
        }

        public static EndOfGame oneEnd()
        {
            if(clearGame == null)
            {
                clearGame = new EndOfGame();
            }
            return clearGame;
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
