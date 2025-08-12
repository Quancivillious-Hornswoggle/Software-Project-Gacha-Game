using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            List<Horse> horses = HorseRacing.setUpRace();
            // Show odds/pictures of each here
            // This list has all horses, you can use it to show info to user :)

            // Currently starting the race immediately, call this method after bet is placed
            HorseRacing.startRace();

        }
    }
}
