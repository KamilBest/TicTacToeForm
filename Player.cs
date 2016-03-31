using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForm
{
    public class Player
    {
        char sign;
        int wins=0;

        /**
        constructor
        */
        public Player(char playerSign)
        {
            sign = playerSign;
        }
        
        /**
        Add win to player
        */
        public void win()
        {
            wins++;
        }

        /** 
        get wins
        */
        public int getWins()
        {
            return wins;
        }

        /**
           get player sign
        */
        public char getSign()
        {
            return sign;
        }

        /**
        reset wins
        */
        public void resetWins()
        {
            wins = 0;
        }
    }
}
