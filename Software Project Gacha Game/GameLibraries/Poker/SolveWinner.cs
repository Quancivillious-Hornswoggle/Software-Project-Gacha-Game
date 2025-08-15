using Software_Project_Gacha_Game.GameLibraries.CardLibrary;

namespace GameLibraries.Poker
{
    public class SolveWinner
    {
        /*public static String DetermineWinner(Hand communityCards, Hand playerHand, Hand opponentHand)
        {
            Card[] playerCards = playerHand.GetCards();
            Card[] opponentCards = opponentHand.GetCards();

            // Compare hands and determine the winner
            if (playerCards.Count > opponentCards.Count)
            {
                return "Player wins";
            }
            else if (playerCards.Count < opponentCards.Count)
            {
                return "Opponent wins";
            }
            return "Draw";
        }

        public static bool IsFlush(Card[] cards)
        {
            //if (cards.Count == 0) return false;

            string suit = cards[0].getSuit();
            foreach (var card in cards)
            {
                if (card.getSuit() != suit) return false;
            }
            return true;
        }*/
    }
}
