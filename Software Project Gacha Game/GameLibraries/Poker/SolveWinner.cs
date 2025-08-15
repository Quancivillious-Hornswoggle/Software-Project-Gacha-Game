using Software_Project_Gacha_Game.GameLibraries.CardLibrary;

namespace GameLibraries.Poker
{
    public class SolveWinner
    {
        internal static String DetermineWinner(Hand communityCards, Hand playerHand, Hand opponentHand)
        {
            Card[] playerCards = new Card[playerHand.GetCards().Length + communityCards.GetCards().Length];
            Array.Copy(playerHand.GetCards(), playerCards, playerHand.GetCards().Length);
            Array.Copy(communityCards.GetCards(), 0, playerCards, playerHand.GetCards().Length, communityCards.GetCards().Length);

            Card[] opponentCards = new Card[opponentHand.GetCards().Length + communityCards.GetCards().Length];
            Array.Copy(opponentHand.GetCards(), opponentCards, opponentHand.GetCards().Length);
            Array.Copy(communityCards.GetCards(), 0, opponentCards, opponentHand.GetCards().Length, communityCards.GetCards().Length);

            /*Lets Start the Hiarchy
            1. Royal Flush
            2. Straight Flush
            3. Four of a Kind
            4. Full House
            5. Flush
            6. Straight
            7. Three of a Kind
            8. Two Pair
            9. One Pair
            10. High Card
            */

            

            return "Draw";
        }


        private static bool IsFlush(Card[] cards)//"♠", "♥", "♦", "♣"
        {
            int heartValue = 0;
            int diamondValue = 0;
            int clubValue = 0;
            int spadeValue = 0;

            if (cards.Length == 0) return false;
            foreach (var card in cards)
            {
                if (card.getSuit() == "♠") heartValue++;
                else if (card.getSuit() == "♥") diamondValue++;
                else if (card.getSuit() == "♦") clubValue++;
                else if (card.getSuit() == "♣") spadeValue++;
            }
            if (heartValue >= 5 || diamondValue >= 5 || clubValue >= 5 || spadeValue >= 5)
            {
                return true;
            }
            return false;
        }



        private static bool IsStraight(Card[] cards)
        {
            if (cards.Length == 0) return false;

            int[] cardValues = getCardValues(cards);
            int straightCount = 1;

            for (int i = 0; i < cardValues.Length; i++)
            {
                if (cardValues[i] == 2 && cardValues[cardValues.Length - 1] == 14)
                {
                    straightCount++;
                }
                if (i > 0 && cardValues[i] == cardValues[i - 1] + 1)
                {
                    straightCount++;
                }
                if (straightCount >= 5)
                {
                    return true;
                }
                else
                {
                    straightCount = 1;
                }
            }
            return false;
        }

        private static int getHighestValue(Card[] cards)
        {
            return getCardValues(cards).Max();
        }
        
        private static int[] getCardValues(Card[] cards)
        {
            Array.Sort(cards, (a, b) => a.getValue().CompareTo(b.getValue()));
            int[] cardValues = new int[cards.Length];
            for (int i = 0; i < cards.Length; i++)
            {
                try
                {
                    cardValues[i] = int.Parse(cards[i].getValue());
                }
                catch
                {
                    if (cards[i].getValue() == "A")
                    {
                        cardValues[i] = 14; // Ace high
                    }
                    else if (cards[i].getValue() == "K")
                    {
                        cardValues[i] = 13; // King high
                    }
                    else if (cards[i].getValue() == "Q")
                    {
                        cardValues[i] = 12; // Queen high
                    }
                    else if (cards[i].getValue() == "J")
                    {
                        cardValues[i] = 11; // Jack high
                    }
                    else
                    {
                        cardValues[i] = 0;
                    }
                }
            }
            return cardValues;
        }
    }
}
