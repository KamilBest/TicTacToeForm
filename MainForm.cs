using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeForm
{
    public partial class MainForm : Form
    {
        Player playerX, playerO, currentPlayer;
        GameBoard gameBoard;
        int moveCounter = 0, drawCounter=0;

        /**
        Constructor - Initialize players, set current player, creating and clearing board.
        */
        public MainForm()
        {
            InitializeComponent();
            playerX = new Player('X');
            playerO = new Player('O');
            currentPlayer = playerX;
            gameBoard = new GameBoard();
            clearBoard();                               
        }

        /**
        Change current player.
        */
        private Player changeCurrentPlayer(Player currentPlayer, Player playerX, Player playerO)
        {
            return currentPlayer == playerX ? playerO : playerX;
        }

        /** 
        BOARD BUTTONS.
        Put current player mark.
        Check whether chosen field is empty or not, if it isn't shows messageBox.
        Check whether current player won or it is a draw.
        runs changeCurrentPlayer method.

        START
        */
        private void button1_Click(object sender, EventArgs e)
        {          
            if (gameBoard.Board[0, 0].isEmpty())
            {
                button1.Text = gameBoard.Board[0, 0].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }      
            displayCurrentPlayerTurn();       
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[0, 1].isEmpty())
            {
                button2.Text = gameBoard.Board[0, 1].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[0, 2].isEmpty())
            {
                button3.Text = gameBoard.Board[0, 2].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[1, 0].isEmpty()) {
                button4.Text = gameBoard.Board[1, 0].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[1, 1].isEmpty())
            {
                button5.Text = gameBoard.Board[1, 1].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[1, 2].isEmpty())
            {
                button6.Text = gameBoard.Board[1, 2].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[2, 0].isEmpty())
            {
                button7.Text = gameBoard.Board[2, 0].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[2, 1].isEmpty())
            {
                button8.Text = gameBoard.Board[2, 1].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[2, 2].isEmpty()) {
                button9.Text = gameBoard.Board[2, 2].markField(currentPlayer).ToString();
                moveCounter++;
                checkWin();
                checkDraw(moveCounter);
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
        }
        /*
        BOARD BUTTONS 
        STOP
        */

        /**
        Display current player turn
        */
        private void displayCurrentPlayerTurn()
        {
            displayTurn.Text = currentPlayer.getSign().ToString();
        }

        /**
        Display players scores
        */
        private void displayScore()
        {
            player1Score.Text = playerX.getWins().ToString();
            player2Score.Text = playerO.getWins().ToString();
        }

        /**
        Prepares board to play again.
        */
        private void playAgain()
        {
            gameBoard.resetBoard();
            clearBoard();
            moveCounter = 0;

        }
        
        /**
        Reset game button.
        After reset game confirmation resets counters, players scores, reset and clear board.
        */
        private void resetGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to reset game? Player scores will be deleted.", "Game reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                moveCounter = 0;
                drawCounter = 0;
                gameBoard.resetBoard();
                playerO.resetWins();
                playerX.resetWins();
                clearBoard();
            }
        }

        /**
        Reset buttons texts, displays Players scores, current player, draws counter.
        */
        private void clearBoard()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            displayCurrentPlayerTurn();
            displayScore();
            displayDraws.Text = drawCounter.ToString();
        }

        /**
        Checks whether it is a draw.
        If counter is equal to number of fields and any player didn't won the game.
        */
        private void checkDraw(int turnCounter)
        {
            if (turnCounter == GameBoard.BOARD_SIZE*GameBoard.BOARD_SIZE)
                setDraw();
        }

        /**
        Set Game when it's draw.
        Adds 1 to drawCounter.
        MessageBox about playing again or not.
        */
        private void setDraw()
        {
            drawCounter++;
            displayDraws.Text = drawCounter.ToString();
            if (MessageBox.Show("Do You want to play again?", "IT IS A DRAW", MessageBoxButtons.YesNo) == DialogResult.Yes)
                playAgain();
            else
            {
                //Next form with final result and quit button
                Application.Exit();
            }
            moveCounter = 0;
        }

      
        /**
        Check all rows for win
        */
        private bool checkRowsForWin()
        {
            for (int i = 0; i < GameBoard.BOARD_SIZE; i++)
            {
                if (checkRowCol(gameBoard.Board[i, 0].getFieldState(), gameBoard.Board[i, 1].getFieldState(), gameBoard.Board[i, 2].getFieldState()))
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
                if (checkRowCol(gameBoard.Board[0, i].getFieldState(), gameBoard.Board[1, i].getFieldState(), gameBoard.Board[2, i].getFieldState()))
                    return true;
            }
            return false;
        }

        /** 
        Check the two diagonals to see if either is a win. Return true if either wins.
        
        */
        private bool checkDiagonalsForWin()
        {
            return ((checkRowCol(gameBoard.Board[0, 0].getFieldState(), gameBoard.Board[1, 1].getFieldState(), gameBoard.Board[2, 2].getFieldState())) || (checkRowCol(gameBoard.Board[0, 2].getFieldState(), gameBoard.Board[1, 1].getFieldState(), gameBoard.Board[2, 0].getFieldState())));
        }

        /**
        Check to see if all three values are the same (and not empty) to indicate a win.
        */
        private bool checkRowCol(FIELD cell1, FIELD cell2, FIELD cell3)
        {
            return (cell1 != FIELD.FLD_EMPTY) && (cell1 == cell2) && (cell2 == cell3);
        }

        /**
        Check to see if all three conditions are true to indicate win.
        */
        private bool checkWinConditions()
        {
            return (checkRowsForWin() || checkColumnsForWin() || checkDiagonalsForWin());
        }
        
        /**
        Check whether someone has won and set win if has.
        */
        private void checkWin()
        {
           if( checkWinConditions())
            {
                setWin();
            }
        }

        /**
        Add win point to player which won (based on current player).
        Display score.
        MessageBox about playing again.
        */
        private void setWin()
        {
            if (currentPlayer == playerX)
                playerX.win();
            else
                playerO.win();
            displayScore();
            if (MessageBox.Show("Do You want to play again?", "Player: " + currentPlayer.getSign().ToString() + " won!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                playAgain();
            else
            {
                //Next form with final result and quit button
                Application.Exit();
            }
        }
    }
}

