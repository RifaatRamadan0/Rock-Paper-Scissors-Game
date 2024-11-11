using RockPaperScissor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enWinner {Player1, Computer, Draw };
        enum enChoices { Rock = 1, Paper = 2, Scissors = 3};
        struct stRoundInfo
        {
            public enWinner RoundWinner;
            public string RoundWinnerName;
            public enChoices Player1Choice;
            public enChoices ComputerChoice;
            public byte RoundNumber;
        };

        struct stGameResult
        {
            public byte GameRounds;
            public enWinner GameWinner;
            public string GameWinnerName;
            public byte Player1WonTimes;
            public byte ComputerWonTimes;
            public byte DrawTimes;
        };

        stRoundInfo RoundInfo;
        stGameResult GameResult;
        private Random random = new Random();

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        void ResetGame()
        {
            // Enable Start Game Button
            BtnStartGame.Enabled = true;

            // Rest Picture Box Image
            PBPlayer1.Image = Resources.question_mark_96;
            PBComputer.Image = Resources.question_mark_96;
            
            // DisEnable all options button
            EnableOptions(false);

            // Reset Game Info
            ResetGameInfo();
        }
        void StartGame()
        {
            // DisEnable Start Game Button
            BtnStartGame.Enabled = false;

            // Enable all options button
            EnableOptions(true);

            // Show Game Info
            LblGameStarted.Visible = true;
            LblGameWinner.Visible = true;
            LblRoundNum.Visible = true;

            // UnEnable Rounds NumericUpDown
            NumUpDownRound.Enabled = false;

            // Initialize Game Result
            GameResult.GameRounds = Convert.ToByte(NumUpDownRound.Value);

            LblRoundNum.Text = (RoundInfo.RoundNumber+1).ToString();
          
        }

        void EnableOptions(bool Enable)
        {
            PBRock.Enabled = Enable;
            PBPaper.Enabled = Enable;
            PBScissor.Enabled = Enable;
        }
        void ResetGameInfo()
        {
            GameResult.Player1WonTimes = 0;
            GameResult.ComputerWonTimes = 0;
            GameResult.DrawTimes = 0;
            RoundInfo.RoundNumber = 0;

            // Hide Game Info
            LblGameStarted.Visible = false;
            LblGameWinner.Visible = false;
            LblRoundNum.Visible = false;

            // Enable Rounds NumericUpDown
            NumUpDownRound.Enabled = true;

            // Reset Game Info Text
            ResetTextGameInfo();
        }
        void ResetTextGameInfo()
        {
            LblPlayer1Wins.Text = GameResult.Player1WonTimes.ToString();
            LblComputerWins.Text = GameResult.ComputerWonTimes.ToString();
            LblGameWinner.Text = "In Progress...";
            LblRoundNum.Text = RoundInfo.RoundNumber.ToString();
        }

        private void PBOptions_Click(object sender, EventArgs e)
        {
            PlayRound((PictureBox)sender);
        }  

        void PlayRound(PictureBox PBPlayerOption)
        {
            ChangePBImage(PBPlayerOption);
            FillRoundInfo();
            FillGameResult();
            UpdateTextRoundScreen();
            CheckGameOver();
        }

        void ChangePBImage(PictureBox PBOption)
        {
            PBPlayer1.Tag = PBOption.Tag;
            PBPlayer1.Image = PBOption.Image;

            PBComputer.Tag = random.Next(1, 4);
            switch (PBComputer.Tag.ToString())
            {
                case "1":
                    PBComputer.Image = Resources.RockImage;
                    break;
                case "2":
                    PBComputer.Image = Resources.PaperImage;
                    break;
                case "3":
                    PBComputer.Image = Resources.ScissorImage;
                    break;
            }

        }

        void FillRoundInfo()
        {
            RoundInfo.RoundNumber++;
            RoundInfo.Player1Choice = (enChoices)Convert.ToInt32(PBPlayer1.Tag);
            RoundInfo.ComputerChoice = (enChoices)Convert.ToInt32(PBComputer.Tag);
            RoundInfo.RoundWinner = DetermineRoundWinner(RoundInfo.Player1Choice, RoundInfo.ComputerChoice);
            RoundInfo.RoundWinnerName = RoundInfo.RoundWinner.ToString();
        }
        enWinner DetermineRoundWinner(enChoices Player1Choice, enChoices ComputerChoice)
        {
            if(Player1Choice == ComputerChoice)
            {
                GameResult.DrawTimes++;
                return enWinner.Draw;
            }

            if(
                (Player1Choice == enChoices.Rock && ComputerChoice == enChoices.Scissors) ||
                (Player1Choice == enChoices.Paper && ComputerChoice == enChoices.Rock) ||
                (Player1Choice == enChoices.Scissors && ComputerChoice == enChoices.Paper)
               )
            {
                GameResult.Player1WonTimes++;
                return enWinner.Player1;
            }

            GameResult.ComputerWonTimes++;
            return enWinner.Computer;
        }

        void FillGameResult()
        {
            GameResult.GameWinner = DetermineGameWinner();
            GameResult.GameWinnerName = GameResult.GameWinner.ToString();
        }
        enWinner DetermineGameWinner()
        {
            if(GameResult.Player1WonTimes > GameResult.ComputerWonTimes)
            {
                return enWinner.Player1;
            }

            if(GameResult.ComputerWonTimes > GameResult.Player1WonTimes)
            {
                return enWinner.Computer;
            }

            return enWinner.Draw;
        }
        void UpdateTextRoundScreen()
        {
            LblPlayer1Wins.Text = GameResult.Player1WonTimes.ToString();
            LblComputerWins.Text = GameResult.ComputerWonTimes.ToString();
            LblRoundNum.Text = RoundInfo.RoundNumber.ToString();
        }

        void CheckGameOver()
        {
            if(RoundInfo.RoundNumber >= GameResult.GameRounds)
            {
                LblGameWinner.Text = "Winner: " + GameResult.GameWinnerName;
                EnableOptions(false);
                MessageBox.Show("Game Over");
            }
        }

        private void BtnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
