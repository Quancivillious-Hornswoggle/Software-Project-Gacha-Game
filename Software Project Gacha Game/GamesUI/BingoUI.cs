using BingoGameApp;
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
    public partial class BingoUI : Form
    {
        //variables
        private BingoGame game;
        private Button[,] cardButtons = new Button[5, 5];
        private ListBox calledNumbersList;
        private Button callNumberButton;
        private Button newGameButton;

        Form1 menuForm;

        public BingoUI(Form1 menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            InitializeGameComponents();
            StartNewGame();
        }

        private void InitializeGameComponents()
        {
            //make card 5x5
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    cardButtons[row, col] = new Button
                    {
                        Size = new Size(80, 80),
                        Location = new Point(col * 85 + 20, row * 85 + 20),
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Tag = new Point(row, col)
                    };
                    this.Controls.Add(cardButtons[row, col]);
                }
            }

            // make number list box
            calledNumbersList = new ListBox
            {
                Size = new Size(150, 400),
                Location = new Point(450, 20),
                Font = new Font("Arial", 10)
            };
            this.Controls.Add(calledNumbersList);

            // make call button
            callNumberButton = new Button
            {
                Text = "Call Number",
                Size = new Size(120, 40),
                Location = new Point(450, 440),
                Font = new Font("Arial", 10)
            };
            callNumberButton.Click += CallNumberButton_Click;
            this.Controls.Add(callNumberButton);

            // make new game button
            newGameButton = new Button
            {
                Text = "New Game",
                Size = new Size(120, 40),
                Location = new Point(580, 440),
                Font = new Font("Arial", 10)
            };
            newGameButton.Click += NewGameButton_Click;
            this.Controls.Add(newGameButton);


            Button returnButton = new Button
            {
                Text = "Return To Menu",
                Size = new Size(120, 40),
                Location = new Point(710, 440),
                Font = new Font("Arial", 10),
                BackColor = Color.Black,
                ForeColor = Color.Red
            };
            returnButton.Click += (sender, e) => { this.Close(); };
            this.Controls.Add(returnButton);
        }

        private void StartNewGame()
        {
            game = new BingoGame();
            game.GenerateCard();
            game.StartGame();
            UpdateCardDisplay();
            calledNumbersList.Items.Clear();
        }

        private void UpdateCardDisplay()
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    string displayText = game.GetDisplayNumber(row, col);
                    cardButtons[row, col].Text = displayText;

                    if (game.IsMarked(row, col))
                    {
                        cardButtons[row, col].BackColor = Color.LightGreen;
                    }
                    else
                    {
                        cardButtons[row, col].BackColor = SystemColors.Control;
                    }
                }
            }
        }

        private void CallNumberButton_Click(object sender, EventArgs e)
        {
            if (game.IsGameActive())
            {
                var result = game.CallNumber();
                if (result != null)
                {
                    calledNumbersList.Items.Add(result.GetFormattedNumber() +
                        (result.FoundOnCard ? " ✓" : ""));

                    UpdateCardDisplay();

                    if (result.Won)
                    {
                        MessageBox.Show("BINGO! You won!", "Congratulations",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        callNumberButton.Enabled = false;
                    }
                }
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
            callNumberButton.Enabled = true;
        }

        private void BingoUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuForm.Visible = true;
        }

        private void BingoUI_Load(object sender, EventArgs e)
        {

        }
    }
}