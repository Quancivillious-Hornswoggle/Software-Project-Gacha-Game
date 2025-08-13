namespace GameLibraries.Poker
{
    public class SolveWinner
    {
        public static String DetermineWinner(Hand communityCards, Hand playerHand, Hand opponentHand)
        {
            List<Card> playerCards = playerHand.GetCards();
            List<Card> opponentCards = opponentHand.GetCards();

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

        public static bool IsFlush(List<Card> cards)
        {
            if (cards.Count == 0) return false;

            string suit = cards[0].Suit;
            foreach (var card in cards)
            {
                if (card.Suit != suit) return false;
            }
            return true;
        }
    }
}
