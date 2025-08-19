using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Software_Project_Gacha_Game.GameLibraries.HorseRacing;

namespace Software_Project_Gacha_Game.Games
{
    public partial class HorseRacingUI : Form
    {
        // Game Variables
        List<Horse> horses = new List<Horse>();
        float BetAmount = 1000;
        PictureBox[] horseIcons = new PictureBox[5];
        Point[] horsePoints = new Point[5];

        // Data Variables
        Form1 menuForm;

        public HorseRacingUI(Form1 menuForm)
        {
            InitializeComponent();

            this.menuForm = menuForm;
        }

        private void HorseRacingUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuForm.Visible = true;
        }

        private void HorseRacingUI_Load(object sender, EventArgs e)
        {
            // Update UI odds
            ResetUI();

            // Initialize the horse icons
            horseIcons[0] = horse1;
            horseIcons[1] = horse2;
            horseIcons[2] = horse3;
            horseIcons[3] = horse4;
            horseIcons[4] = horse5;

            // Initialize the horse points
            horsePoints[0] = horse1.Location;
            horsePoints[1] = horse1.Location;
            horsePoints[2] = horse2.Location;
            horsePoints[3] = horse3.Location;
            horsePoints[4] = horse4.Location;

            // Hide payout panel and button
            payoutPanel.Visible = false;
            BetAgainButton.Visible = false;
        }

        private void ResetUI()
        {
            // Set up horses
            horses = HorseRacing.setUpRace();

            // Odds
            odds1.Text = horses[0].getOdds().ToString();
            odds2.Text = horses[1].getOdds().ToString();
            odds3.Text = horses[2].getOdds().ToString();
            odds4.Text = horses[3].getOdds().ToString();
            odds5.Text = horses[4].getOdds().ToString();

            // Winner
            winnerLabel.Text = "No Winner Yet";

            // Names
            name1.Text = horses[0].getName().ToString();
            name2.Text = horses[1].getName().ToString();
            name3.Text = horses[2].getName().ToString();
            name4.Text = horses[3].getName().ToString();
            name5.Text = horses[4].getName().ToString();

            // Bet Buttons
            EnableBetButtons();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            menuForm.Visible = true;
            this.Close();
        }

        #region Bet Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            HorseRacing.makeBet(horses[0].getName(), float.Parse(betAmount.Text));
            DisableBetButtons();
            float winnings = HorseRacing.startRace(horseIcons, winnerLabel);
            ShowPayout(winnings);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HorseRacing.makeBet(horses[1].getName(), float.Parse(betAmount.Text));
            DisableBetButtons();
            float winnings = HorseRacing.startRace(horseIcons, winnerLabel);
            ShowPayout(winnings);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HorseRacing.makeBet(horses[2].getName(), float.Parse(betAmount.Text));
            DisableBetButtons();
            float winnings = HorseRacing.startRace(horseIcons, winnerLabel);
            ShowPayout(winnings);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HorseRacing.makeBet(horses[3].getName(), float.Parse(betAmount.Text));
            DisableBetButtons();
            float winnings = HorseRacing.startRace(horseIcons, winnerLabel);
            ShowPayout(winnings);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HorseRacing.makeBet(horses[4].getName(), float.Parse(betAmount.Text));
            DisableBetButtons();
            float winnings = HorseRacing.startRace(horseIcons, winnerLabel);
            ShowPayout(winnings);
        }

        private void DisableBetButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            increaseButton.Enabled = false;
            decreaseButton.Enabled = false;
        }

        private void EnableBetButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            increaseButton.Enabled = true;
            decreaseButton.Enabled = true;
        }

        private void ShowPayout(float winnings)
        {
            payoutLabel.Text = $"${winnings}";
            payoutPanel.Visible = true;
            BetAgainButton.Visible = true;
        }
        #endregion

        #region Bet Adjuster Buttons
        private void increaseButton_Click(object sender, EventArgs e)
        {
            BetAmount += 1000;
            betAmount.Text = BetAmount.ToString();
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            BetAmount -= 1000;
            if (BetAmount < 0)
                BetAmount = 0;
            betAmount.Text = BetAmount.ToString();
        }
        #endregion

        #region Button Hover Data
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.ForestGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.ForestGreen;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkRed;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.ForestGreen;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkRed;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.ForestGreen;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkRed;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.ForestGreen;
        }
        #endregion

        private void BetAgainButton_Click(object sender, EventArgs e)
        {
            ResetUI();
            payoutPanel.Visible = false;
            BetAgainButton.Visible = false;

            // Reset horses
            horse1.Location = horsePoints[0];
            horse2.Location = horsePoints[1];
            horse3.Location = horsePoints[2];
            horse4.Location = horsePoints[3];
            horse5.Location = horsePoints[4];
        }
    }
}
