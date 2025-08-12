namespace Software_Project_Gacha_Game.Games
{
    partial class SlotsUI
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
            pictureBox1 = new PictureBox();
            slot1 = new Label();
            slot2 = new Label();
            slot3 = new Label();
            spinButton = new Button();
            returnButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.slotMachine;
            pictureBox1.Location = new Point(61, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1058, 592);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // slot1
            // 
            slot1.BackColor = Color.Black;
            slot1.Font = new Font("Segoe UI", 75F);
            slot1.ForeColor = Color.Cyan;
            slot1.Location = new Point(322, 309);
            slot1.Name = "slot1";
            slot1.Padding = new Padding(15, 0, 0, 15);
            slot1.Size = new Size(140, 178);
            slot1.TabIndex = 1;
            slot1.Text = "💣";
            slot1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // slot2
            // 
            slot2.BackColor = Color.Black;
            slot2.Font = new Font("Segoe UI", 75F);
            slot2.ForeColor = Color.Cyan;
            slot2.Location = new Point(487, 309);
            slot2.Name = "slot2";
            slot2.Padding = new Padding(15, 0, 0, 15);
            slot2.Size = new Size(140, 178);
            slot2.TabIndex = 2;
            slot2.Text = "💣";
            slot2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // slot3
            // 
            slot3.BackColor = Color.Black;
            slot3.Font = new Font("Segoe UI", 75F);
            slot3.ForeColor = Color.Cyan;
            slot3.Location = new Point(652, 309);
            slot3.Name = "slot3";
            slot3.Padding = new Padding(15, 0, 0, 15);
            slot3.Size = new Size(140, 178);
            slot3.TabIndex = 3;
            slot3.Text = "💣";
            slot3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // spinButton
            // 
            spinButton.BackColor = Color.Transparent;
            spinButton.BackgroundImage = Properties.Resources.redCircle;
            spinButton.BackgroundImageLayout = ImageLayout.Stretch;
            spinButton.FlatAppearance.BorderSize = 0;
            spinButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            spinButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            spinButton.FlatStyle = FlatStyle.Flat;
            spinButton.Location = new Point(840, 117);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(55, 55);
            spinButton.TabIndex = 4;
            spinButton.UseVisualStyleBackColor = false;
            spinButton.Click += Run_Slots;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.Black;
            returnButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            returnButton.FlatAppearance.BorderSize = 3;
            returnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButton.ForeColor = Color.FromArgb(192, 0, 0);
            returnButton.Location = new Point(12, 572);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(171, 54);
            returnButton.TabIndex = 5;
            returnButton.Text = "Return To Menu";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // SlotsUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.slots;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 638);
            Controls.Add(returnButton);
            Controls.Add(spinButton);
            Controls.Add(slot3);
            Controls.Add(slot2);
            Controls.Add(slot1);
            Controls.Add(pictureBox1);
            Name = "SlotsUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Slots";
            FormClosing += SlotsUI_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label slot1;
        private Label slot2;
        private Label slot3;
        private Button spinButton;
        private Button returnButton;
    }
}