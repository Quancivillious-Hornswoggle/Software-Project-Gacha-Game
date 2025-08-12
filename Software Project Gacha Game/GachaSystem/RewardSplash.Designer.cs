namespace Software_Project_Gacha_Game.GachaSystem
{
    partial class RewardSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            rewardLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.rewardBG;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.rewardBG;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 400);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 25F);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(100, 250);
            button1.Name = "button1";
            button1.Size = new Size(200, 80);
            button1.TabIndex = 1;
            button1.Text = "Collect 😀";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(rewardLabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 0;
            // 
            // rewardLabel
            // 
            rewardLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rewardLabel.BackColor = Color.Transparent;
            rewardLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rewardLabel.ForeColor = Color.Cyan;
            rewardLabel.Location = new Point(100, 103);
            rewardLabel.Margin = new Padding(3, 0, 3, 15);
            rewardLabel.Name = "rewardLabel";
            rewardLabel.Padding = new Padding(0, 25, 0, 0);
            rewardLabel.Size = new Size(200, 147);
            rewardLabel.TabIndex = 4;
            rewardLabel.Text = "You unlocked REWARD!";
            rewardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RewardSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 400);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RewardSplash";
            Text = "RewardSplash";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button1;
        private Panel panel1;
        private Label rewardLabel;
    }
}