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
        Constructor.
        Prepares Board to play.
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
            Board = new Cell[BOARD_SIZE, BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    Board[i, j] = new Cell();
                }
            }
        }

        /**
        Method resets board to primary state - set cells to empty state.
        */
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
    }
}

