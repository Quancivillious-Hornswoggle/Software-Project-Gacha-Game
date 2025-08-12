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
            button1 = new Button();
            rewardLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 25F);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(134, 398);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(315, 133);
            button1.TabIndex = 1;
            button1.Text = "Collect 😀";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rewardLabel
            // 
            rewardLabel.BackColor = Color.Transparent;
            rewardLabel.CausesValidation = false;
            rewardLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rewardLabel.ForeColor = Color.Cyan;
            rewardLabel.Location = new Point(134, 245);
            rewardLabel.Margin = new Padding(4, 0, 4, 25);
            rewardLabel.Name = "rewardLabel";
            rewardLabel.Size = new Size(315, 101);
            rewardLabel.TabIndex = 4;
            rewardLabel.Text = "You unlocked REWARD!";
            rewardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.rewardBG;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RewardSplash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(rewardLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "RewardSplash";
            Text = "RewardSplash";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Label rewardLabel;
        private PictureBox pictureBox1;
    }
}