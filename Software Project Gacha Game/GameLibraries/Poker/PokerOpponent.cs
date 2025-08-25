using Software_Project_Gacha_Game.GameLibraries.CardLibrary;
using static Poker;
namespace GameLibraries.Poker
{
    public class PokerOpponent
    {
        private Hand opponentHand;
        private Hand communityCards;

        internal PokerOpponent(Hand opponentHand, Hand communityCards)
        {
            this.opponentHand = opponentHand;
            this.communityCards = communityCards;
        }

        internal Hand GetOpponentHand()
        {
            return opponentHand;
        }

        internal void SetOpponentHand(Hand hand)
        {
            opponentHand = hand;
        }

        internal Hand GetCommunityCards()
        {
            return communityCards;
        }

        internal void SetCommunityCards(Hand hand)
        {
            communityCards = hand;
        }

        internal PlayerChoices opponentChoice()
        {
            Random rand = new Random();
            int choice = rand.Next(1, 4); 

            switch (choice)
            {
                case 1:
                    return PlayerChoices.Fold;
                case 2:
                    return PlayerChoices.Call;
                case 3:
                    return PlayerChoices.Raise;
                default:
                    return PlayerChoices.Call; // Default case, should not occur
            }
        }
    }
}