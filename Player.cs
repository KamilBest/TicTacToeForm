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
        int wins=0, losses=0;
        /**
        constructor
        */
        public Player(char playerSign)
        {
            sign = playerSign;
        }
        public void win()
        {
            wins++;
        }
        public int getWins()
        {
            return wins;
        }
        public int getLosses()
        {
            return losses;
        }
        public void lose()
        {
            losses++;
        }
        /**
           get player sign
        */
        public char getSign()
        {
            return sign;
        }
  

    }
}
