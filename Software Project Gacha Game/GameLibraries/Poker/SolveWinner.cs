namespace GameLibraries.Poker
{
    public class SolveWinner
    {
        public String DetermineWinner(Hand communityCards, Hand playerHand, Hand opponentHand)
        {
            List<Card> playerCards = new List<Card>(playerHand.GetCards());
            playerCards.AddRange(communityCards.GetCards());
            List<Card> opponentCards = new List<Card>(opponentHand.GetCards());
            opponentCards.AddRange(communityCards.GetCards());

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


        public bool IsFlush(List<Card> cards)
        {
            if (cards.Count == 0) return false;

            string suit = cards[0].Suit;
            foreach (var card in cards)
            {
                if (card.Suit != suit) return false;
            }
            return true;
        }

        public bool IsStraight(List<Card> cards)
        {
            if (cards.Count == 0) return false;

            cards.Sort((a, b) => a.Value.CompareTo(b.Value));

            for (int i = 1; i < cards.Count; i++)
            {
                if (i == 0 && cards[i].Value == 1 && cards[i - 1].Value == 10)
                {
                    // Check for the special case of Ace-low straight
                    if (cards[i].Value != cards[i - 1].Value + 1)
                    {
                        return false;
                    }
                }
                else if (cards[i].Value != cards[i - 1].Value + 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
