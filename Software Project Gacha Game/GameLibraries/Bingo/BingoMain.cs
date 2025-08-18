using BingoGameApp;
using System;

namespace Com.Example
{
    public class BingoMain
    {
        public static void start()
        {
            BingoGame game = new BingoGame();
            game.GenerateCard();
            game.StartGame();

            for (int i = 0; i < 50 && game.IsGameActive(); i++)
            {
                var result = game.CallNumber();
                if (result != null)
                {
                    Console.WriteLine("Called: " + result.GetFormattedNumber() +
                        (result.FoundOnCard ? " (on card)" : " (not on card)"));
                    if (result.Won)
                    {
                        Console.WriteLine("BINGO!");
                        break;
                    }
                }
            }
        }
    }
}
