namespace Software_Project_Gacha_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            titleLabel = new Label();
            panel2 = new Panel();
            pokerButton = new Button();
            blackjackButton = new Button();
            bingoButton = new Button();
            horseButton = new Button();
            slotsButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1598, 250);
            panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1598, 250);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Miku's Child Support Rehab Center";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pokerButton);
            panel2.Controls.Add(blackjackButton);
            panel2.Controls.Add(bingoButton);
            panel2.Controls.Add(horseButton);
            panel2.Controls.Add(slotsButton);
            panel2.Location = new Point(0, 196);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 745);
            panel2.TabIndex = 1;
            // 
            // pokerButton
            // 
            pokerButton.BackColor = Color.Black;
            pokerButton.Font = new Font("Arial Black", 13F);
            pokerButton.ForeColor = Color.Green;
            pokerButton.Location = new Point(1270, 587);
            pokerButton.Margin = new Padding(4, 5, 4, 5);
            pokerButton.Name = "pokerButton";
            pokerButton.Size = new Size(306, 147);
            pokerButton.TabIndex = 4;
            pokerButton.Text = "POKER";
            pokerButton.UseVisualStyleBackColor = false;
            pokerButton.Click += pokerButton_Click;
            pokerButton.MouseEnter += pokerButton_MouseEnter;
            pokerButton.MouseLeave += pokerButton_MouseLeave;
            // 
            // blackjackButton
            // 
            blackjackButton.BackColor = Color.Black;
            blackjackButton.Font = new Font("Arial Black", 13F);
            blackjackButton.ForeColor = Color.Green;
            blackjackButton.Location = new Point(956, 587);
            blackjackButton.Margin = new Padding(4, 5, 4, 5);
            blackjackButton.Name = "blackjackButton";
            blackjackButton.Size = new Size(306, 147);
            blackjackButton.TabIndex = 3;
            blackjackButton.Text = "BLACKJACK";
            blackjackButton.UseVisualStyleBackColor = false;
            blackjackButton.Click += blackjackButton_Click;
            blackjackButton.MouseEnter += blackjackButton_MouseEnter;
            blackjackButton.MouseLeave += blackjackButton_MouseLeave;
            // 
            // bingoButton
            // 
            bingoButton.BackColor = Color.Black;
            bingoButton.Font = new Font("Arial Black", 13F);
            bingoButton.ForeColor = Color.Green;
            bingoButton.Location = new Point(642, 587);
            bingoButton.Margin = new Padding(4, 5, 4, 5);
            bingoButton.Name = "bingoButton";
            bingoButton.Size = new Size(306, 147);
            bingoButton.TabIndex = 2;
            bingoButton.Text = "BINGO";
            bingoButton.UseVisualStyleBackColor = false;
            bingoButton.Click += bingoButton_Click;
            bingoButton.MouseEnter += bingoButton_MouseEnter;
            bingoButton.MouseLeave += bingoButton_MouseLeave;
            // 
            // horseButton
            // 
            horseButton.BackColor = Color.Black;
            horseButton.Font = new Font("Arial Black", 13F);
            horseButton.ForeColor = Color.Green;
            horseButton.Location = new Point(327, 587);
            horseButton.Margin = new Padding(4, 5, 4, 5);
            horseButton.Name = "horseButton";
            horseButton.Size = new Size(306, 147);
            horseButton.TabIndex = 1;
            horseButton.Text = "HORSE RACING";
            horseButton.UseVisualStyleBackColor = false;
            horseButton.Click += horseButton_Click;
            horseButton.MouseEnter += horseButton_MouseEnter;
            horseButton.MouseLeave += horseButton_MouseLeave;
            // 
            // slotsButton
            // 
            slotsButton.AutoSize = true;
            slotsButton.BackColor = Color.Black;
            slotsButton.Font = new Font("Arial Black", 13F);
            slotsButton.ForeColor = Color.Green;
            slotsButton.Location = new Point(13, 587);
            slotsButton.Margin = new Padding(4, 5, 4, 5);
            slotsButton.Name = "slotsButton";
            slotsButton.Size = new Size(306, 147);
            slotsButton.TabIndex = 0;
            slotsButton.Text = "SLOTS";
            slotsButton.UseVisualStyleBackColor = false;
            slotsButton.Click += slotsButton_Click;
            slotsButton.MouseEnter += slotsButton_MouseEnter;
            slotsButton.MouseLeave += slotsButton_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.menubackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1598, 944);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Miku's Child Support Rehab Center";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titleLabel;
        private Panel panel2;
        private Button slotsButton;
        private Button pokerButton;
        private Button blackjackButton;
        private Button bingoButton;
        private Button horseButton;
    }
}
