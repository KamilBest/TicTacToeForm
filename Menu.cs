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
    public partial class Menu : Form
    {
        private MainForm mainForm;
        private Rules rulesForm;
        public Menu()
        {
            InitializeComponent();
        }

        /**
        Runs two players game.
        */
        private void twoPlayers_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm = new MainForm();
            mainForm.Show();

        }

        /**
        Exit game
        */
        private void exitGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to exit game?", "Exit game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        /**
        Shows rules form
        */
        private void rules_Click(object sender, EventArgs e)
        {
            rulesForm = new Rules();
            rulesForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
