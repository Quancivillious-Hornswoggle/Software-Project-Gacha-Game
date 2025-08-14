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
    public partial class PokerUI : Form
    {


        // Data Variables
        Form1 menuForm;

        public PokerUI(Form1 menuForm)
        {
            InitializeComponent();

            this.menuForm = menuForm;

            // Hide hand
            hand1.Image = null; hand1.BackColor = Color.Transparent;
            hand2.Image = null; hand2.BackColor = Color.Transparent;
        }

        private void PokerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuForm.Visible = true;
        }
    }
}
