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
    public partial class Form1 : Form
    {
        Player playerX, playerO, currentPlayer;
        GameBoard gameBoard;
        int moveCounter = 0;
        public Form1()
        {
            InitializeComponent();
            playerX = new Player('X');
            playerO = new Player('O');

            currentPlayer = playerX;
            gameBoard = new GameBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
       

        private Player changeCurrentPlayer(Player currentPlayer, Player playerX, Player playerO)
        {
            return currentPlayer == playerX ? playerO : playerX;

        }

        private void button1_Click(object sender, EventArgs e)
        {          
            if (gameBoard.Board[0, 0].isEmpty())
            {
                button1.Text = gameBoard.Board[0, 0].markField(currentPlayer).ToString();
                checkWin();

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }      
            displayCurrentPlayerTurn();
            checkDraw(moveCounter);
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[0, 1].isEmpty())
            {
                button2.Text = gameBoard.Board[0, 1].markField(currentPlayer).ToString();
                checkWin();

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();

            checkDraw(moveCounter);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[0, 2].isEmpty())
            {
                button3.Text = gameBoard.Board[0, 2].markField(currentPlayer).ToString();
                checkWin();

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();

            checkDraw(moveCounter);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[1, 0].isEmpty()) {
                button4.Text = gameBoard.Board[1, 0].markField(currentPlayer).ToString();
                checkWin();

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();

            checkDraw(moveCounter);

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[1, 1].isEmpty())
            {
                button5.Text = gameBoard.Board[1, 1].markField(currentPlayer).ToString();
                checkWin();

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();

            checkDraw(moveCounter);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[1, 2].isEmpty())
            {
                button6.Text = gameBoard.Board[1, 2].markField(currentPlayer).ToString();
                checkWin();

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();

            checkDraw(moveCounter);

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[2, 0].isEmpty())
            {
                button7.Text = gameBoard.Board[2, 0].markField(currentPlayer).ToString();
                checkWin();

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();
            gameBoard.checkWin();

            checkDraw(moveCounter);

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[2, 1].isEmpty())
            {
                button8.Text = gameBoard.Board[2, 1].markField(currentPlayer).ToString();
                checkWin();
                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();

            checkDraw(moveCounter);

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (gameBoard.Board[2, 2].isEmpty()) {
                button9.Text = gameBoard.Board[2, 2].markField(currentPlayer).ToString();
                checkWin();

                currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                moveCounter++;
            }
            else
            {
                MessageBox.Show("Field is not empty!");
            }
            displayCurrentPlayerTurn();

            checkDraw(moveCounter);

        }

        private void displayCurrentPlayerTurn()
        {
            displayTurn.Text = currentPlayer.getSign().ToString();
        }

        private void playAgain()
        {
            gameBoard.resetBoard();
            clearBoard();
            moveCounter = 0;

        }
        private void resetGame_Click(object sender, EventArgs e)
        {
            gameBoard.resetBoard();
            clearBoard();
            player1Score.Text = "";
            player2Score.Text = "";
        }
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
            displayTurn.Text = "";
        }
        private void checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                setDraw();
        }
        private void setDraw()
        {           
                playerX.win();
                playerO.win();
                player1Score.Text = playerX.getWins().ToString();
                player2Score.Text = playerO.getWins().ToString();
                MessageBox.Show("IT IS A DRAW!");
                moveCounter = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkWin()
        {
           
            if (gameBoard.checkWin())
            {
                setWin();
            }
            
        }
        private void setWin()
        {
            if (currentPlayer == playerX)
                playerX.win();
            else
                playerO.win();
            player1Score.Text = playerX.getWins().ToString();
            player2Score.Text = playerO.getWins().ToString();
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
