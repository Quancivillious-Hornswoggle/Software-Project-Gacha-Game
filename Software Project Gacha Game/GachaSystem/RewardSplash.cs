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
        string Reward = string.Empty;
        public RewardSplash(string reward)
        {
            InitializeComponent();

            // Set raw reward 
            Reward = reward;

            // Set open position to center
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set parent to display background
            rewardLabel.Parent = pictureBox2;

            // Set reward title
            rewardLabel.Text = "You Unlocked " + reward + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Optional switch case to physically reward something
            switch (Reward)
            {
                case "Sticker Pack":

                    break;
                case "Wallpaper":

                    break;
                case "Ringtone":

                    break;
                case "Animated Avatar":

                    break;
                case "Miku Voice Greeting":

                    break;

            }

            this.Close();
        }
    }
}
