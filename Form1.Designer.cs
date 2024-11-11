namespace RockPaperScissor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelGameMenu = new System.Windows.Forms.Panel();
            this.LblComputerWins = new System.Windows.Forms.Label();
            this.LblPlayer1Wins = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumUpDownRound = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnResetGame = new System.Windows.Forms.Button();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.PanelGame = new System.Windows.Forms.Panel();
            this.LblRoundNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblGameWinner = new System.Windows.Forms.Label();
            this.LblGameStarted = new System.Windows.Forms.Label();
            this.PBScissor = new System.Windows.Forms.PictureBox();
            this.PBPaper = new System.Windows.Forms.PictureBox();
            this.PBRock = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PBComputer = new System.Windows.Forms.PictureBox();
            this.PBPlayer1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelGameMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownRound)).BeginInit();
            this.PanelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGameMenu
            // 
            this.PanelGameMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PanelGameMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGameMenu.Controls.Add(this.LblComputerWins);
            this.PanelGameMenu.Controls.Add(this.LblPlayer1Wins);
            this.PanelGameMenu.Controls.Add(this.label3);
            this.PanelGameMenu.Controls.Add(this.label2);
            this.PanelGameMenu.Controls.Add(this.NumUpDownRound);
            this.PanelGameMenu.Controls.Add(this.label1);
            this.PanelGameMenu.Controls.Add(this.BtnResetGame);
            this.PanelGameMenu.Controls.Add(this.BtnStartGame);
            this.PanelGameMenu.Location = new System.Drawing.Point(39, 72);
            this.PanelGameMenu.Name = "PanelGameMenu";
            this.PanelGameMenu.Size = new System.Drawing.Size(326, 464);
            this.PanelGameMenu.TabIndex = 0;
            // 
            // LblComputerWins
            // 
            this.LblComputerWins.AutoSize = true;
            this.LblComputerWins.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputerWins.Location = new System.Drawing.Point(199, 183);
            this.LblComputerWins.Name = "LblComputerWins";
            this.LblComputerWins.Size = new System.Drawing.Size(19, 19);
            this.LblComputerWins.TabIndex = 7;
            this.LblComputerWins.Text = "0";
            // 
            // LblPlayer1Wins
            // 
            this.LblPlayer1Wins.AutoSize = true;
            this.LblPlayer1Wins.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer1Wins.Location = new System.Drawing.Point(78, 183);
            this.LblPlayer1Wins.Name = "LblPlayer1Wins";
            this.LblPlayer1Wins.Size = new System.Drawing.Size(19, 19);
            this.LblPlayer1Wins.TabIndex = 6;
            this.LblPlayer1Wins.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 1";
            // 
            // NumUpDownRound
            // 
            this.NumUpDownRound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumUpDownRound.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownRound.Location = new System.Drawing.Point(86, 106);
            this.NumUpDownRound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownRound.Name = "NumUpDownRound";
            this.NumUpDownRound.ReadOnly = true;
            this.NumUpDownRound.Size = new System.Drawing.Size(133, 23);
            this.NumUpDownRound.TabIndex = 0;
            this.NumUpDownRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownRound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Round To Start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnResetGame
            // 
            this.BtnResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnResetGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetGame.Location = new System.Drawing.Point(80, 332);
            this.BtnResetGame.Name = "BtnResetGame";
            this.BtnResetGame.Size = new System.Drawing.Size(145, 48);
            this.BtnResetGame.TabIndex = 2;
            this.BtnResetGame.Text = "Reset Game";
            this.BtnResetGame.UseVisualStyleBackColor = true;
            this.BtnResetGame.Click += new System.EventHandler(this.BtnResetGame_Click);
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnStartGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartGame.Location = new System.Drawing.Point(80, 254);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(145, 48);
            this.BtnStartGame.TabIndex = 1;
            this.BtnStartGame.Text = "Start Game";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // PanelGame
            // 
            this.PanelGame.BackColor = System.Drawing.Color.Blue;
            this.PanelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGame.Controls.Add(this.LblRoundNum);
            this.PanelGame.Controls.Add(this.label7);
            this.PanelGame.Controls.Add(this.LblGameWinner);
            this.PanelGame.Controls.Add(this.LblGameStarted);
            this.PanelGame.Controls.Add(this.PBScissor);
            this.PanelGame.Controls.Add(this.PBPaper);
            this.PanelGame.Controls.Add(this.PBRock);
            this.PanelGame.Controls.Add(this.label6);
            this.PanelGame.Controls.Add(this.PBComputer);
            this.PanelGame.Controls.Add(this.PBPlayer1);
            this.PanelGame.Controls.Add(this.label5);
            this.PanelGame.Controls.Add(this.label4);
            this.PanelGame.Location = new System.Drawing.Point(362, 72);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(682, 464);
            this.PanelGame.TabIndex = 1;
            // 
            // LblRoundNum
            // 
            this.LblRoundNum.AutoSize = true;
            this.LblRoundNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoundNum.ForeColor = System.Drawing.Color.White;
            this.LblRoundNum.Location = new System.Drawing.Point(350, 122);
            this.LblRoundNum.Name = "LblRoundNum";
            this.LblRoundNum.Size = new System.Drawing.Size(14, 16);
            this.LblRoundNum.TabIndex = 11;
            this.LblRoundNum.Text = "1";
            this.LblRoundNum.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(301, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Round";
            // 
            // LblGameWinner
            // 
            this.LblGameWinner.AutoSize = true;
            this.LblGameWinner.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblGameWinner.Location = new System.Drawing.Point(268, 58);
            this.LblGameWinner.Name = "LblGameWinner";
            this.LblGameWinner.Size = new System.Drawing.Size(138, 23);
            this.LblGameWinner.TabIndex = 9;
            this.LblGameWinner.Text = "In Progress...";
            this.LblGameWinner.Visible = false;
            // 
            // LblGameStarted
            // 
            this.LblGameStarted.AutoSize = true;
            this.LblGameStarted.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameStarted.ForeColor = System.Drawing.Color.Red;
            this.LblGameStarted.Location = new System.Drawing.Point(268, 12);
            this.LblGameStarted.Name = "LblGameStarted";
            this.LblGameStarted.Size = new System.Drawing.Size(140, 23);
            this.LblGameStarted.TabIndex = 8;
            this.LblGameStarted.Text = "Game Started";
            this.LblGameStarted.Visible = false;
            // 
            // PBScissor
            // 
            this.PBScissor.BackColor = System.Drawing.Color.White;
            this.PBScissor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBScissor.Enabled = false;
            this.PBScissor.Image = global::RockPaperScissor.Properties.Resources.ScissorImage;
            this.PBScissor.Location = new System.Drawing.Point(470, 375);
            this.PBScissor.Name = "PBScissor";
            this.PBScissor.Size = new System.Drawing.Size(88, 60);
            this.PBScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBScissor.TabIndex = 7;
            this.PBScissor.TabStop = false;
            this.PBScissor.Tag = "3";
            this.PBScissor.Click += new System.EventHandler(this.PBOptions_Click);
            // 
            // PBPaper
            // 
            this.PBPaper.BackColor = System.Drawing.Color.White;
            this.PBPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBPaper.Enabled = false;
            this.PBPaper.Image = global::RockPaperScissor.Properties.Resources.PaperImage;
            this.PBPaper.Location = new System.Drawing.Point(300, 375);
            this.PBPaper.Name = "PBPaper";
            this.PBPaper.Size = new System.Drawing.Size(88, 60);
            this.PBPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPaper.TabIndex = 6;
            this.PBPaper.TabStop = false;
            this.PBPaper.Tag = "2";
            this.PBPaper.Click += new System.EventHandler(this.PBOptions_Click);
            // 
            // PBRock
            // 
            this.PBRock.BackColor = System.Drawing.Color.White;
            this.PBRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBRock.Enabled = false;
            this.PBRock.Image = global::RockPaperScissor.Properties.Resources.RockImage;
            this.PBRock.Location = new System.Drawing.Point(136, 375);
            this.PBRock.Name = "PBRock";
            this.PBRock.Size = new System.Drawing.Size(88, 60);
            this.PBRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBRock.TabIndex = 5;
            this.PBRock.TabStop = false;
            this.PBRock.Tag = "1";
            this.PBRock.Click += new System.EventHandler(this.PBOptions_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(268, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choose an Option";
            // 
            // PBComputer
            // 
            this.PBComputer.BackColor = System.Drawing.Color.White;
            this.PBComputer.Image = global::RockPaperScissor.Properties.Resources.question_mark_96;
            this.PBComputer.Location = new System.Drawing.Point(408, 146);
            this.PBComputer.Name = "PBComputer";
            this.PBComputer.Size = new System.Drawing.Size(174, 139);
            this.PBComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBComputer.TabIndex = 3;
            this.PBComputer.TabStop = false;
            // 
            // PBPlayer1
            // 
            this.PBPlayer1.BackColor = System.Drawing.Color.White;
            this.PBPlayer1.Image = global::RockPaperScissor.Properties.Resources.question_mark_96;
            this.PBPlayer1.Location = new System.Drawing.Point(90, 146);
            this.PBPlayer1.Name = "PBPlayer1";
            this.PBPlayer1.Size = new System.Drawing.Size(174, 139);
            this.PBPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPlayer1.TabIndex = 2;
            this.PBPlayer1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(457, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Computer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(139, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player 1";
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnStartGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 607);
            this.Controls.Add(this.PanelGame);
            this.Controls.Add(this.PanelGameMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "  Rock Paper Scissors";
            this.PanelGameMenu.ResumeLayout(false);
            this.PanelGameMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownRound)).EndInit();
            this.PanelGame.ResumeLayout(false);
            this.PanelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGameMenu;
        private System.Windows.Forms.Panel PanelGame;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Button BtnResetGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumUpDownRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblComputerWins;
        private System.Windows.Forms.Label LblPlayer1Wins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PBPlayer1;
        private System.Windows.Forms.PictureBox PBComputer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PBPaper;
        private System.Windows.Forms.PictureBox PBRock;
        private System.Windows.Forms.PictureBox PBScissor;
        private System.Windows.Forms.Label LblGameStarted;
        private System.Windows.Forms.Label LblGameWinner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblRoundNum;
    }
}

