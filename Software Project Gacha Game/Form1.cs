using Software_Project_Gacha_Game.GachaSystem;
using Software_Project_Gacha_Game.Games;
using System.Runtime.CompilerServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace Software_Project_Gacha_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Button Hover Logic
        private void slotsButton_MouseEnter(object sender, EventArgs e)
        {
            slotsButton.ForeColor = Color.Red;
        }

        private void slotsButton_MouseLeave(object sender, EventArgs e)
        {
            slotsButton.ForeColor = Color.Green;
        }

        private void horseButton_MouseEnter(object sender, EventArgs e)
        {
            horseButton.ForeColor = Color.Red;
        }

        private void horseButton_MouseLeave(object sender, EventArgs e)
        {
            horseButton.ForeColor = Color.Green;
        }

        private void bingoButton_MouseEnter(object sender, EventArgs e)
        {
            bingoButton.ForeColor = Color.Red;
        }

        private void bingoButton_MouseLeave(object sender, EventArgs e)
        {
            bingoButton.ForeColor = Color.Green;
        }

        private void blackjackButton_MouseEnter(object sender, EventArgs e)
        {
            blackjackButton.ForeColor = Color.Red;
        }

        private void blackjackButton_MouseLeave(object sender, EventArgs e)
        {
            blackjackButton.ForeColor = Color.Green;
        }

        private void pokerButton_MouseEnter(object sender, EventArgs e)
        {
            pokerButton.ForeColor = Color.Red;
        }

        private void pokerButton_MouseLeave(object sender, EventArgs e)
        {
            pokerButton.ForeColor = Color.Green;
        }
        #endregion

        #region Button Click Logic
        private void slotsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SlotsUI slots = new SlotsUI();
            slots.Show();
        }

        private void horseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HorseRacingUI horseRacing = new HorseRacingUI();
            horseRacing.Show();
        }

        private void bingoButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BingoUI bingo = new BingoUI();
            bingo.Show();
        }

        private void blackjackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BlackjackUI blackjack = new BlackjackUI();
            blackjack.Show();
        }

        private void pokerButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PokerUI poker = new PokerUI();
            poker.Show();
        }
        #endregion

        #region Form Execptions
        private void BingoUI_Deactivate(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
