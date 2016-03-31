using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForm
{
    public class GameBoard
    {
        public const int BOARD_SIZE = 3;
        public Cell[,] Board;
        /**
        Constructor 
            */

        public GameBoard()
        {
            initializeBoard();
        }

        /**
        Initialize Board - set board fields as empty
            */
        private void initializeBoard()
        {
           Board = new Cell[BOARD_SIZE,BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    Board[i, j] = new Cell();
                }
            }
        }

        public void resetBoard()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    Board[i, j].setEmpty();
                }
            }
        }

        /**
      Check all rows for win
  */
        private bool checkRowsForWin()
        {
            for (int i = 0; i < GameBoard.BOARD_SIZE; i++)
            {
                if (checkRowCol(Board[i, 0].getFieldState(), Board[i, 1].getFieldState(),Board[i, 2].getFieldState()))
                {

                    return true;
                }
            }
            return false;
        }
        /**
           Check all columns for win
       */
        private bool checkColumnsForWin()
        {
            for (int i = 0; i < GameBoard.BOARD_SIZE; i++)
            {
                if (checkRowCol(Board[0, i].getFieldState(), Board[1, i].getFieldState(), Board[2, i].getFieldState()))
                    return true;
            }
            return false;
        }

        /** 
        Check the two diagonals to see if either is a win. Return true if either wins.
        
            */
        private bool checkDiagonalsForWin()
        {
            return ((checkRowCol(Board[0, 0].getFieldState(), Board[1, 1].getFieldState(), Board[2, 2].getFieldState()) == true) || (checkRowCol(Board[0, 2].getFieldState(), Board[1, 1].getFieldState(), Board[2, 0].getFieldState()) == true));
        }

        /**
        Check to see if all three values are the same (and not empty) indicating a win.
    */
        private bool checkRowCol(FIELD c1, FIELD c2, FIELD c3)
        {

            return (c1 != FIELD.FLD_EMPTY) && (c1 == c2) && (c2 == c3);
        }

        /**
        Check to see if all three conditions are true indicating win.
    */
        public bool checkWin()
        {
            return (checkRowsForWin() || checkColumnsForWin() || checkDiagonalsForWin());
        }
    }
}
