using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForm
{
    public class Cell
    {
        FIELD fieldState;

        /**
        Constructor, set cell empty on create.
        */
        public Cell()
        {
            fieldState = FIELD.FLD_EMPTY;
        }
        
        /**
        Get field (cell) state 
        */
        public FIELD getFieldState()
        {
            return fieldState;
        }

        /**
        Set Cell empty on reset
        */
        public void setEmpty()
        {
            fieldState = FIELD.FLD_EMPTY;
        }

        /**
        Check whether cell is empty
        */
        public bool isEmpty()
        {
            if (fieldState!= FIELD.FLD_EMPTY)
                return false;
            return true;
        }

        /**
        Mark cell with current player sign.
        */
        public char markField(Player player)
        {
            if(isEmpty())
            {
                if (player.getSign() == 'X')
                    fieldState = FIELD.FLD_X;
                else
                    fieldState = FIELD.FLD_O;
            }
            return (char)fieldState.GetHashCode();
        }
    }
}
