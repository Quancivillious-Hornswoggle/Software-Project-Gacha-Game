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
    public partial class HorseRacingUI : Form
    {


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
            HorseRacing.setUpRace();
        }
    }
}
