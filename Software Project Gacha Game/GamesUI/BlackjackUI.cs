using GameLibraries.Poker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project_Gacha_Game.Games
{
    public partial class BlackjackUI : Form
    {
        // Game Variables
        Blackjack blackjack = new Blackjack();

        // Data Variables
        Form1 menuForm;

        public BlackjackUI(Form1 menuForm)
        {
            InitializeComponent();

            this.menuForm = menuForm;

            // Hide popup panel
            popupPanel.Hide();

            // Hide Player Cards
            cardSlot1.Image = null; cardSlot1.BackColor = Color.FromArgb(34, 30, 23);
            cardSlot2.Image = null; cardSlot2.BackColor = Color.FromArgb(34, 30, 23);
            cardSlot3.Image = null; cardSlot3.BackColor = Color.FromArgb(34, 30, 23);
            cardSlot4.Image = null; cardSlot4.BackColor = Color.FromArgb(34, 30, 23);
            cardSlot5.Image = null; cardSlot5.BackColor = Color.FromArgb(34, 30, 23);
            cardSlot6.Image = null; cardSlot6.BackColor = Color.FromArgb(34, 30, 23);

            // Hide Dealer Cards
            dealerSlot1.Image = null; dealerSlot1.BackColor = Color.DarkGray;
            dealerSlot2.Image = null; dealerSlot2.BackColor = Color.DarkGray;
            dealerSlot3.Image = null; dealerSlot3.BackColor = Color.DarkGray;
            dealerSlot4.Image = null; dealerSlot4.BackColor = Color.DarkGray;
            dealerSlot5.Image = null; dealerSlot5.BackColor = Color.DarkGray;
            dealerSlot6.Image = null; dealerSlot6.BackColor = Color.DarkGray;

            // GREEN FN!$!$!$
        }

        private void BlackjackUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuForm.Visible = true;
        }

        private void BlackjackUI_Load(object sender, EventArgs e)
        {
            blackjack.StartGame();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            blackjack.PlayerHits();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            blackjack.PlayerStands();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            blackjack.StartGame();
        }

        // Update UI with hands
        private void UpdateUI(Hand playerHand, Hand dealerHand)
        {
            // Set dealer hand
            List<Card> cards = playerHand.GetCards();

            // Set player hand
        }

        private void UpdatePlayerHand(Hand playerHand)
        {

        }
    }
}
