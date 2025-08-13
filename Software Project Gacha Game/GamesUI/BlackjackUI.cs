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


        // Data Variables
        Form1 menuForm;

        public BlackjackUI(Form1 menuForm)
        {
            InitializeComponent();

            this.menuForm = menuForm;

            // Hide popup panel
            popupPanel.Hide();

            // Hide Player Cards
            cardSlot1.Image = null; cardSlot1.BackColor = Color.SeaGreen;
            cardSlot2.Image = null; cardSlot2.BackColor = Color.SeaGreen;
            cardSlot3.Image = null; cardSlot3.BackColor = Color.SeaGreen;
            cardSlot4.Image = null; cardSlot4.BackColor = Color.SeaGreen;
            cardSlot5.Image = null; cardSlot5.BackColor = Color.SeaGreen;
            cardSlot6.Image = null; cardSlot6.BackColor = Color.SeaGreen;

            // Hide Dealer Cards
            dealerSlot1.Image = null ; dealerSlot1.BackColor = Color.DarkGray;
            dealerSlot2.Image = null ; dealerSlot2.BackColor = Color.DarkGray;
            dealerSlot3.Image = null ; dealerSlot3.BackColor = Color.DarkGray;
            dealerSlot4.Image = null ; dealerSlot4.BackColor = Color.DarkGray;
            dealerSlot5.Image = null ; dealerSlot5.BackColor = Color.DarkGray;
            dealerSlot6.Image = null ; dealerSlot6.BackColor = Color.DarkGray;
        }

        private void BlackjackUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuForm.Visible = true;
        }

        private void BlackjackUI_Load(object sender, EventArgs e)
        {

        }
    }
}
