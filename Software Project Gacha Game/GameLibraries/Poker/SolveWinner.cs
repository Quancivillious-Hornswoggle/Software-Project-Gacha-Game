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
            if (IsStraightFlush(playerCards) && IsStraightFlush(opponentCards)) 
            {// I hope to come back to this to make it more efficient, but it should work for now
                if (getHighestValue(playerCards) > getHighestValue(opponentCards))
                {
                    return "Player wins";
                }
                else if (getHighestValue(playerCards) < getHighestValue(opponentCards))
                {
                    return "Opponent wins";
                }
            } else if (IsStraightFlush(playerCards))
            {
                return "Player wins";
            }
            else if (IsStraightFlush(opponentCards))
            {
                return "Opponent wins";
            }
            if (IsFourOfAKind(playerCards) && IsFourOfAKind(opponentCards))
            {
                if (getHighestValue(playerCards) > getHighestValue(opponentCards))
                {
                    return "Player wins";
                }
                else if (getHighestValue(playerCards) < getHighestValue(opponentCards))
                {
                    return "Opponent wins";
                }
            } else if (IsFourOfAKind(playerCards))
            {
                return "Player wins";
            }
            else if (IsFourOfAKind(opponentCards))
            {
                return "Opponent wins";
            }// Ok theres gotta be a better way to handle this... but... for time sake i'll come back to this
            if (IsFullHouse(playerCards) && IsFullHouse(opponentCards))
            {
                if (getHighestValue(playerCards) > getHighestValue(opponentCards))
                {
                    return "Player wins";
                }
                else if (getHighestValue(playerCards) < getHighestValue(opponentCards))
                {
                    return "Opponent wins";
                }
            }
            else if (IsFullHouse(playerCards))
            {
                return "Player wins";
            }
            else if (IsFullHouse(opponentCards))
            {
                return "Opponent wins";
            }
            if (IsFlush(playerCards) && IsFlush(opponentCards))
            {
                if (getHighestValue(playerCards) > getHighestValue(opponentCards))
                {
                    return "Player wins";
                }
                else if (getHighestValue(playerCards) < getHighestValue(opponentCards))
                {
                    return "Opponent wins";
                }
            }
            else if (IsFlush(playerCards))
            {
                return "Player wins";
            }
            else if (IsFlush(opponentCards))
            {
                return "Opponent wins";
            }
            if (IsStraight(playerCards) && IsStraight(opponentCards))
            {
                if (getHighestValue(playerCards) > getHighestValue(opponentCards))
                {
                    return "Player wins";
                }
                else if (getHighestValue(playerCards) < getHighestValue(opponentCards))
                {
                    return "Opponent wins";
                }
            }else if (IsStraight(playerCards))
            {
                return "Player wins";
            }
            else if (IsStraight(opponentCards))
            {
                return "Opponent wins";
            }
            if (IsThreeOfAKind(playerCards) && IsThreeOfAKind(opponentCards))
            {
                if (getHighestValue(playerCards) > getHighestValue(opponentCards))
                {
                    return "Player wins";
                }
                else if (getHighestValue(playerCards) < getHighestValue(opponentCards))
                {
                    return "Opponent wins";
                }
            }
            else if (IsThreeOfAKind(playerCards))
            {
                return "Player wins";
            }
            else if (IsThreeOfAKind(opponentCards))
            {
                return "Opponent wins";
            }
            if (IsTwoPair(playerCards) && IsTwoPair(opponentCards))
            {
                if (getHighestValue(playerCards) > getHighestValue(opponentCards))
                {
                    return "Player wins";
                }
                else if (getHighestValue(playerCards) < getHighestValue(opponentCards))
                {
                    return "Opponent wins";
                }
            }
            else if (IsTwoPair(playerCards))
            {
                return "Player wins";
            }
            else if (IsTwoPair(opponentCards))
            {
                return "Opponent wins";
            }
            if (IsOnePair(playerCards) && IsOnePair(opponentCards))
            {
                if (getHighestValue(playerCards) > getHighestValue(opponentCards))
                {
                    return "Player wins";
                }
                else if (getHighestValue(playerCards) < getHighestValue(opponentCards))
                {
                    return "Opponent wins";
                }
            }
            else if (IsOnePair(playerCards))
            {
                return "Player wins";
            }
            else if (IsOnePair(opponentCards))
            {
                return "Opponent wins";
            }
            if (getHighestValue(playerCards) != getHighestValue(opponentCards))
            {
                return getHighestValue(playerCards) > getHighestValue(opponentCards) ? "Player wins" : "Opponent wins";
            }

            return "Draw";
        }

        private static bool IsStraightFlush(Card[] cards)
        {
            Card[] fiveCardHand = new Card[5]; //since the player can work with any 5 cards we must exclude the others in the river
            int startIndex = straightStartIndex(cards);
            if (startIndex != -1)
            {
                Array.Copy(cards, startIndex, fiveCardHand, 0, 5);
            }
            if (IsFlush(fiveCardHand) && IsStraight(fiveCardHand)) // make sure that the straight is ALSO a flush
            {
                return true;
            }

            /*
            * NOTE: IsStraightFlush() && IsFlush() does not work on the complete hand since something like
            * 5♠ 6♠ 7♠ 8♠ 9♠ (straight flush) is not recognized if the player has 2♣ 3♣ in hand.
            */

            return false;
        }

        private static bool IsFourOfAKind(Card[] cards)
        {
            int[] valueCounts = new int[15]; // 2-14 (Ace)
            int[] cardValues = getCardValues(cards);
            foreach (var value in cardValues)
            {
                valueCounts[value]++;
            }
            return valueCounts.Contains(4);
        }

        private static bool IsFullHouse(Card[] cards)
        {
            return IsThreeOfAKind(cards) && IsOnePair(cards);
        }
        private static bool IsThreeOfAKind(Card[] cards)
        {
            int[] valueCounts = new int[15]; // 2-14 (Ace)
            int[] cardValues = getCardValues(cards);
            foreach (var value in cardValues)
            {
                valueCounts[value]++;
            }
            return valueCounts.Contains(3);
        }

        private static bool IsTwoPair(Card[] cards)
        {
            return CountPairs(cards) == 2;
        }

        private static bool IsOnePair(Card[] cards)
        {
            int[] valueCounts = new int[15]; // 2-14 (Ace)
            int[] cardValues = getCardValues(cards);
            foreach (var value in cardValues)
            {
                valueCounts[value]++;
            }
            return valueCounts.Contains(2);
        }

        private static int CountPairs(Card[] cards)
        {
            int[] valueCounts = new int[15]; // 2-14 (Ace)
            int[] cardValues = getCardValues(cards);
            foreach (var value in cardValues)
            {
                valueCounts[value]++;
            }
            return valueCounts.Count(x => x == 2);
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

        private static int straightStartIndex(Card[] cards)
        {
            for (int i = 0; i < cards.Length - 4; i++)
            {
                if (IsStraight(new Card[] { cards[i], cards[i + 1], cards[i + 2], cards[i + 3], cards[i + 4] }))
                {
                    return i;
                }
            }
            return -1;
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
