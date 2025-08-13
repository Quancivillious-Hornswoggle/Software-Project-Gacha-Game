namespace GameLibraries.Poker
{ //Note* The style of Poker will be Texas Hold'em
    public class Hand //The player's hands will be 2 cards, the community cards will be 5
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            cards.Remove(card);
        }

        public List<Card> GetCards()
        {
            return cards;
        }
    }
}