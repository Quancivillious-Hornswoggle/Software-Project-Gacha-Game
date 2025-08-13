using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Project_Gacha_Game.GameLibraries.Blackjack
{
    internal class Deck
    {
        private Card[] deck;
        private int currentCardIndex;

        public Deck()
        {
            deck = new Card[52];
            string[] suits = { "♠", "♥", "♦", "♣" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            int index = 0;

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck[index++] = new Card(suit, rank);
                }
            }
            currentCardIndex = 0;

        }
        //TODO: Implement shuffle method


        //TODO: Implement a method to deal a card
    }
}
