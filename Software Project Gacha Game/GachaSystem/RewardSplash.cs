using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project_Gacha_Game.GachaSystem
{
    public partial class RewardSplash : Form
    {
        public RewardSplash(string reward)
        {
            InitializeComponent();

            // Set open position to center
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set parent to display background
            rewardLabel.Parent = pictureBox2;

            // Set reward title
            rewardLabel.Text = "You Unlocked " + reward + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
