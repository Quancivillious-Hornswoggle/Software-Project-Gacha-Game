namespace Software_Project_Gacha_Game.GameLibraries.CardLibrary
{
internal class Hand
{
    private int cardCount;
    private Card[] hand;

    public Hand()
    {
        hand = new Card[6]; // max possible cards in blackjack without busting
        cardCount = 0;
    }

    public void AddCard(Card card)
    {
        if (cardCount < hand.Length)
        {
            hand[cardCount++] = card;
        }
        else
        {
            throw new InvalidOperationException("Hand is full.");
        }
    }

    public void RemoveCard(Card card)
    {
        List<Card> cards = new List<Card>();
        cards.Remove(card);
        cardCount -= cards.Count;
    }

    public int GetHandValue()
    {
        int totalValue = 0;
        int aceCount = 0;

        for (int i = 0; i < cardCount; i++)
        {
            string rank = hand[i].getValue();
            if (rank == "A")
            {  //count as 11 initially 
                totalValue += 11;
                aceCount++;
            }
            else if (rank == "K" || rank == "Q" || rank == "J")
            {
                totalValue += 10;
            }
            else
            {
                totalValue += int.Parse(rank);
            }
        }

        while (totalValue > 21 && aceCount > 0)
        { //change to 1
            totalValue -= 10;
            aceCount--;
        }

        return totalValue;
    }

    public Card[] GetCards()
    {
        return hand;
    }

    public void ClearHand()
    {
        for (int i = 0; i < cardCount; i++)
        {
            hand[i] = null;
        }
        cardCount = 0;
    }

    public override string ToString()
    {
        string output = "";
        for (int i = 0; i < cardCount; i++)
        {
            output += hand[i].ToString() + " ";
        }
        return output.Trim();
    }
}
}
