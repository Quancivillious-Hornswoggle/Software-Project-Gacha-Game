namespace Software_Project_Gacha_Game.Games
{
    partial class PokerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokerUI));
            communitySlot1 = new PictureBox();
            communitySlot4 = new PictureBox();
            communitySlot2 = new PictureBox();
            communitySlot3 = new PictureBox();
            communitySlot5 = new PictureBox();
            label1 = new Label();
            hand1 = new PictureBox();
            hand2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)communitySlot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communitySlot4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communitySlot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communitySlot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communitySlot5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hand1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hand2).BeginInit();
            SuspendLayout();
            // 
            // communitySlot1
            // 
            communitySlot1.Image = (Image)resources.GetObject("communitySlot1.Image");
            communitySlot1.ImageLocation = "";
            communitySlot1.Location = new Point(471, 807);
            communitySlot1.Name = "communitySlot1";
            communitySlot1.Size = new Size(90, 125);
            communitySlot1.SizeMode = PictureBoxSizeMode.CenterImage;
            communitySlot1.TabIndex = 1;
            communitySlot1.TabStop = false;
            // 
            // communitySlot4
            // 
            communitySlot4.Image = (Image)resources.GetObject("communitySlot4.Image");
            communitySlot4.ImageLocation = "";
            communitySlot4.Location = new Point(759, 807);
            communitySlot4.Name = "communitySlot4";
            communitySlot4.Size = new Size(90, 125);
            communitySlot4.SizeMode = PictureBoxSizeMode.CenterImage;
            communitySlot4.TabIndex = 2;
            communitySlot4.TabStop = false;
            // 
            // communitySlot2
            // 
            communitySlot2.Image = (Image)resources.GetObject("communitySlot2.Image");
            communitySlot2.ImageLocation = "";
            communitySlot2.Location = new Point(567, 807);
            communitySlot2.Name = "communitySlot2";
            communitySlot2.Size = new Size(90, 125);
            communitySlot2.SizeMode = PictureBoxSizeMode.CenterImage;
            communitySlot2.TabIndex = 2;
            communitySlot2.TabStop = false;
            // 
            // communitySlot3
            // 
            communitySlot3.Image = (Image)resources.GetObject("communitySlot3.Image");
            communitySlot3.ImageLocation = "";
            communitySlot3.Location = new Point(663, 807);
            communitySlot3.Name = "communitySlot3";
            communitySlot3.Size = new Size(90, 125);
            communitySlot3.SizeMode = PictureBoxSizeMode.CenterImage;
            communitySlot3.TabIndex = 3;
            communitySlot3.TabStop = false;
            // 
            // communitySlot5
            // 
            communitySlot5.Image = (Image)resources.GetObject("communitySlot5.Image");
            communitySlot5.ImageLocation = "";
            communitySlot5.Location = new Point(855, 807);
            communitySlot5.Name = "communitySlot5";
            communitySlot5.Size = new Size(90, 125);
            communitySlot5.SizeMode = PictureBoxSizeMode.CenterImage;
            communitySlot5.TabIndex = 4;
            communitySlot5.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(567, 697);
            label1.Name = "label1";
            label1.Size = new Size(282, 107);
            label1.TabIndex = 5;
            label1.Text = "Community Cards";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hand1
            // 
            hand1.Image = (Image)resources.GetObject("hand1.Image");
            hand1.ImageLocation = "";
            hand1.Location = new Point(997, 750);
            hand1.Name = "hand1";
            hand1.Size = new Size(160, 225);
            hand1.SizeMode = PictureBoxSizeMode.Zoom;
            hand1.TabIndex = 6;
            hand1.TabStop = false;
            // 
            // hand2
            // 
            hand2.Image = (Image)resources.GetObject("hand2.Image");
            hand2.ImageLocation = "";
            hand2.Location = new Point(1203, 750);
            hand2.Name = "hand2";
            hand2.Size = new Size(160, 225);
            hand2.SizeMode = PictureBoxSizeMode.Zoom;
            hand2.TabIndex = 7;
            hand2.TabStop = false;
            // 
            // PokerUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cardGameBg;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1418, 944);
            Controls.Add(hand2);
            Controls.Add(hand1);
            Controls.Add(label1);
            Controls.Add(communitySlot5);
            Controls.Add(communitySlot3);
            Controls.Add(communitySlot2);
            Controls.Add(communitySlot4);
            Controls.Add(communitySlot1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "PokerUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poker";
            FormClosing += PokerUI_FormClosing;
            ((System.ComponentModel.ISupportInitialize)communitySlot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)communitySlot4).EndInit();
            ((System.ComponentModel.ISupportInitialize)communitySlot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)communitySlot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)communitySlot5).EndInit();
            ((System.ComponentModel.ISupportInitialize)hand1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hand2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox communitySlot1;
        private PictureBox communitySlot4;
        private PictureBox communitySlot2;
        private PictureBox communitySlot3;
        private PictureBox communitySlot5;
        private Label label1;
        private PictureBox hand1;
        private PictureBox hand2;
    }
}