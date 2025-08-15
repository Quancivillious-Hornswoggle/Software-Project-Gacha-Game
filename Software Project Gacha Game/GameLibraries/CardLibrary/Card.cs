using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Project_Gacha_Game.GameLibraries.CardLibrary
{
    internal class Card
    {
        private string Suit;
        private string Rank;

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public string getValue()
        {
            return Rank;
        }
        public string getSuit()
        {
            return Suit;
        }

        public override string ToString() => $"{Rank} + {Suit}";
    }
}
