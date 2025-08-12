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
            SuspendLayout();
            // 
            // PokerUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 944);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PokerUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poker";
            FormClosing += PokerUI_FormClosing;
            ResumeLayout(false);
        }

        #endregion
    }
}