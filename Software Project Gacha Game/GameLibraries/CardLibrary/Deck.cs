using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Project_Gacha_Game.GameLibraries.CardLibrary
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

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = deck.Length - 1; i > 0; i--)
            { //swaps decks i and j
                int j = rand.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
            currentCardIndex = 0;
        }

        public Card DealCard()
        {
            if (currentCardIndex < deck.Length)
            {
                return deck[currentCardIndex++];
            }
            else
            { //this aint ever gonna happen
                throw new InvalidOperationException("No more cards to deal.");
            }
        }

        public bool discardCard(Card card)
        {
            try
            {
                List<Card> cards = deck.ToList();
                cards.Remove(card);
                deck = cards.ToArray();
                return true;
            } catch
            {
                return false;
            }
        }
    }
}
