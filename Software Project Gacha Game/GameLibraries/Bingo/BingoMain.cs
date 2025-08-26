using BingoGameApp;
using System;

namespace Software_Project_Gacha_Game.Games
{
    public static class BingoMain
    {
        public static void start(Form1 menuForm)
        {
            BingoUI bingoForm = new BingoUI(menuForm);
            menuForm.Visible = false;
            bingoForm.Show();
        }
    }
}
