using GameLibraries.Poker;
using Software_Project_Gacha_Game.GameLibraries.CardLibrary;
using System;
using System.Collections;
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

            // Set Dealer Card Parent
            /*dealerSlot1.Parent = dealerCardPanel;
            dealerSlot2.Parent = dealerCardPanel;
            dealerSlot3.Parent = dealerCardPanel;
            dealerSlot4.Parent = dealerCardPanel;
            dealerSlot5.Parent = dealerCardPanel;
            dealerSlot6.Parent = dealerCardPanel;*/

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
            UpdateUI(blackjack.GetPlayerHand(), blackjack.GetDealerHand());
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            bool bust = blackjack.PlayerHits();
            UpdateUI(blackjack.GetPlayerHand(), blackjack.GetDealerHand());
            if (bust)
            { 
                popupMessage.Text = "You Busted!"; //he he he he
                popupPanel.Show();
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            int win = blackjack.PlayerStands();
            UpdateUI(blackjack.GetPlayerHand(), blackjack.GetDealerHand());
            switch (win)
            {
                case 0: // Win
                    popupMessage.Text = "You Won!";
                    popupPanel.Show();
                    break;
                case 1: // Lose
                    popupMessage.Text = "You Lost!";
                    popupPanel.Show();
                    break;
                case 2: // Tie
                    popupMessage.Text = "Push!";
                    popupPanel.Show();
                    break;
            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            popupPanel.Hide();
            blackjack.StartGame();
            UpdateUI(blackjack.GetPlayerHand(), blackjack.GetDealerHand());
        }

        // Update UI with hands
        private void UpdateUI(Hand playerHand, Hand dealerHand)
        {
            // Set dealer hand
            Card[] dealerCards = dealerHand.GetCards();
            PictureBox[] dealerCardSlots = { dealerSlot1, dealerSlot2, dealerSlot3, dealerSlot4, dealerSlot5, dealerSlot6 };
            foreach (PictureBox slot in dealerCardSlots) 
            {
                
                slot.Image = null;
            }
            for (int i = 0; i < dealerCards.Length; i++)
            {
                if (dealerCards[i] != null && dealerCardSlots[i] != null)
                {
                    string cardValue = dealerCards[i].getValue();
                    string cardSuit = dealerCards[i].getSuit();
                    string image = Path.Combine(Application.StartupPath, "GameResources", "Cards", $"{cardValue}{cardSuit}.png");
                    dealerCardSlots[i].Image = Image.FromFile(image);
                }
            }

            // Set player hand
            UpdatePlayerHand(playerHand);

            // Update total
            totalLabel.Text = $"Total: {playerHand.GetHandValue().ToString()}";
        }

        private void UpdatePlayerHand(Hand playerHand)
        {
            List<Card> playerCards = playerHand.GetCards().ToList();
            playerCards.RemoveAll(item => item == null);
            PictureBox[] slots = { cardSlot1, cardSlot2, cardSlot3, cardSlot4, cardSlot5, cardSlot6 };

            // Clear all slots
            foreach (var slot in slots)
                slot.Image = null;
            List<string> cardImages = new List<string>();
            foreach (var card in playerCards)
            {
                string image = Path.Combine(Application.StartupPath, "GameResources", "Cards", $"{card.getValue()}{card.getSuit()}.png");
                cardImages.Add(image);
            }
            switch (playerCards.Count)
            {
                case 2:
                    cardSlot3.Image = Image.FromFile(cardImages[0]);
                    cardSlot4.Image = Image.FromFile(cardImages[1]);
                    break;
                case 3:
                    cardSlot3.Image = Image.FromFile(cardImages[0]);
                    cardSlot4.Image = Image.FromFile(cardImages[1]);
                    cardSlot5.Image = Image.FromFile(cardImages[2]);
                    break;
                case 4:
                    cardSlot2.Image = Image.FromFile(cardImages[0]);
                    cardSlot3.Image = Image.FromFile(cardImages[1]);
                    cardSlot4.Image = Image.FromFile(cardImages[2]);
                    cardSlot5.Image = Image.FromFile(cardImages[3]);
                    break;
                case 5:
                    cardSlot2.Image = Image.FromFile(cardImages[0]);
                    cardSlot3.Image = Image.FromFile(cardImages[1]);
                    cardSlot4.Image = Image.FromFile(cardImages[2]);
                    cardSlot5.Image = Image.FromFile(cardImages[3]);
                    cardSlot6.Image = Image.FromFile(cardImages[4]);
                    break;
                case 6:
                    cardSlot1.Image = Image.FromFile(cardImages[0]);
                    cardSlot2.Image = Image.FromFile(cardImages[1]);
                    cardSlot3.Image = Image.FromFile(cardImages[2]);
                    cardSlot4.Image = Image.FromFile(cardImages[3]);
                    cardSlot5.Image = Image.FromFile(cardImages[4]);
                    cardSlot6.Image = Image.FromFile(cardImages[5]);
                    break;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            menuForm.Visible = true;
        }
    }
}
