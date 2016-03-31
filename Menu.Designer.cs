namespace TicTacToeForm
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.singlePlayer = new System.Windows.Forms.Button();
            this.twoPlayers = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.exitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 14.25F);
            this.label1.Location = new System.Drawing.Point(123, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by Kamil Best";
            // 
            // singlePlayer
            // 
            this.singlePlayer.Enabled = false;
            this.singlePlayer.Location = new System.Drawing.Point(105, 75);
            this.singlePlayer.Name = "singlePlayer";
            this.singlePlayer.Size = new System.Drawing.Size(128, 26);
            this.singlePlayer.TabIndex = 2;
            this.singlePlayer.Text = "1 Player";
            this.singlePlayer.UseVisualStyleBackColor = true;
            // 
            // twoPlayers
            // 
            this.twoPlayers.Location = new System.Drawing.Point(105, 107);
            this.twoPlayers.Name = "twoPlayers";
            this.twoPlayers.Size = new System.Drawing.Size(128, 26);
            this.twoPlayers.TabIndex = 3;
            this.twoPlayers.Text = "2 players";
            this.twoPlayers.UseVisualStyleBackColor = true;
            this.twoPlayers.Click += new System.EventHandler(this.twoPlayers_Click);
            // 
            // rules
            // 
            this.rules.Location = new System.Drawing.Point(105, 139);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(128, 26);
            this.rules.TabIndex = 4;
            this.rules.Text = "Rules";
            this.rules.UseVisualStyleBackColor = true;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // options
            // 
            this.options.Enabled = false;
            this.options.Location = new System.Drawing.Point(105, 171);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(128, 26);
            this.options.TabIndex = 5;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            // 
            // exitGame
            // 
            this.exitGame.Location = new System.Drawing.Point(105, 203);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(128, 26);
            this.exitGame.TabIndex = 6;
            this.exitGame.Text = "Exit game";
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 286);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.options);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.twoPlayers);
            this.Controls.Add(this.singlePlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button singlePlayer;
        private System.Windows.Forms.Button twoPlayers;
        private System.Windows.Forms.Button rules;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button exitGame;
    }
}