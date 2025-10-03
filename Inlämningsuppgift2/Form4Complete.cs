using Inlämningsuppgift2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift2
{
    public partial class Form4Complete : Form
    {
        Player _player;
        AI _ai;
        public Form4Complete()
        {
            InitializeComponent();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            Form3Game.form3GameInstance.ResetOnStart();
            _ai.Reset();
            _player.Reset();
            this.Close();
        }

        public void InitiateForm4(string header, string message, bool win, Player player, AI ai, int currentScore)
        {
            _player = player;
            _ai = ai;
            labelHeader.Text = header;
            labelMessage.Text = message;
            labelCurrentScore.Text = $"My current score {currentScore}";
            labelTotalScore.ForeColor = Color.Red;
            labelTotalScore.Text = $"My total score: {GetTotalScore(currentScore)}";
            Game.Instance.user.MyScore += currentScore;
            DataHandler.Save(Game.Instance.user);

            if (!win)
            {
                labelHeader.ForeColor = Color.Red;
            }
            else
            {
                labelHeader.ForeColor = Color.Green;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int GetTotalScore(int currentScore)
        {
            int totalScore = Game.Instance.user.MyScore + currentScore;
            return totalScore;
        }

        private void labelCurrentScore_Click(object sender, EventArgs e)
        {

        }
    }
}
