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

        public Cell()
        {
            fieldState = FIELD.FLD_EMPTY;
        }
        public FIELD getFieldState()
        {
            return fieldState;
        }
        public void setEmpty()
        {
            fieldState = FIELD.FLD_EMPTY;
        }
        public bool isEmpty()
        {
            if (fieldState!= FIELD.FLD_EMPTY)
                return false;
            return true;
        }

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
