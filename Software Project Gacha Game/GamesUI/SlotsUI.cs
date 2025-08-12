using Software_Project_Gacha_Game.GachaSystem;
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
    public partial class SlotsUI : Form
    {
        // UI Variables
        private Label Slot1;
        private Label Slot2;
        private Label Slot3;

        // Data Variables
        Form1 menuForm;

        public SlotsUI(Form1 menuForm)
        {
            InitializeComponent();

            this.menuForm = menuForm;

            // Initialize UI variables
            Slot1 = slot1;
            Slot2 = slot2;
            Slot3 = slot3;
        }

        private async void Run_Slots(object sender, EventArgs e)
        {
            // Disable spin button
            spinButton.Enabled = false;

            // Create slots game and start running dat john
            Slots slots = new Slots();

            // Run game code and get 3 slots data
            string[] slotChoices = slots.RunGame();

            // Update UI to spin to the symbols
            // Possible symbols (adjust to match your game)
            string[] symbols = slots.GetSlotSymbols();

            // Spin all slots
            await Task.WhenAll(
                SpinSlot(Slot1, symbols, slotChoices[0], 50, 15),
                SpinSlot(Slot2, symbols, slotChoices[1], 50, 20),
                SpinSlot(Slot3, symbols, slotChoices[2], 50, 25)
            );

            // Award reward if 2 in a row
            if (slotChoices[0] == slotChoices[1] || slotChoices[1] == slotChoices[2] || slotChoices[0] == slotChoices[2])
            {
                // Create new reward pack and award it
                Pack newPack = new Pack();
                string reward = newPack.GetReward().ToString();
                RewardSplash rewardSplash = new RewardSplash(reward);
                rewardSplash.Show();
            }

            // Re enable the spin button
            spinButton.Enabled = true;
        }

        private async Task SpinSlot(Label slotLabel, string[] symbols, string finalSymbol, int startDelay, int stepsToStop)
        {
            int delay = startDelay;
            Random rand = new Random();
            int index = 0;

            // Spin for a set number of steps, increasing delay each time
            for (int i = 0; i < stepsToStop; i++)
            {
                index = (index + 1) % symbols.Length;
                slotLabel.Text = symbols[index];
                await Task.Delay(delay);
                delay += 20; // slows down each loop
            }

            // Ensure it stops on the correct final symbol
            slotLabel.Text = finalSymbol;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            menuForm.Visible = true;
            this.Close();
        }

        private void SlotsUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuForm.Visible = true;
        }
    }
}
