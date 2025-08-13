namespace GameLibraries.Poker;

public class Deck
{
    private List<Card> cards;
    private List<Card> discardedCards;

    public Deck()
    {
        cards = new List<Card>();
        InitializeDeck();
        discardedCards = new List<Card>();
    }

    public void InitializeDeck()
    {
        string[] suits = { "H", "D", "C", "S" };
        for (int i = 1; i <= 13; i++)
        {
            foreach (var suit in suits)
            {
                cards.Add(new Card(suit, i, $"{i}_{suit}.png"));
            }
        }
    }

    public void Shuffle()
    {
        Random rng = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            int k = rng.Next(n--);
            Card temp = cards[n];
            cards[n] = cards[k];
            cards[k] = temp;
        }
    }

    public void DiscardCard(Card card)
    {
        discardedCards.Add(card);
    }

    /**
    * Shuffles the discarded cards back into the deck
    * This will be used at the end of a round sequence after a given number of turns to provide a more thourough shuffle
    **/
    public void ShuffleDiscardedIntoDeck() 
    {
        Random rng = new Random();
        int n = discardedCards.Count;
        while (n > 1)
        {
            int k = rng.Next(n--);
            Card temp = discardedCards[n];
            discardedCards[n] = discardedCards[k];
            discardedCards[k] = temp;
        }
        cards.AddRange(discardedCards);
        discardedCards.Clear();
    }
    /**
    * Adds all discarded cards back to the deck (without shuffling)
    **/
    public void AddDiscardedCardsToDeck()
    {
        cards.AddRange(discardedCards);
        discardedCards.Clear();
    }

    public Card DrawCard()
    {
        // This can create duplicate cards IF the players currently have cards in their hand.
        // The game logic should SHUFFLE and refresh the deck before playing a round if too few cards are left. 
        if (cards.Count == 0)
            ShuffleDiscardedIntoDeck();

        Card drawnCard = cards[0];
        cards.RemoveAt(0);
        DiscardCard(drawnCard);
        return drawnCard;
    }
}
