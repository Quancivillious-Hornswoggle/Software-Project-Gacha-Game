using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibraries.Poker;
using Software_Project_Gacha_Game.GameLibraries.CardLibrary;

class Poker
{
    /*
    Card card = new Card("H", 11, "11H.png");
    Card card2 = new Card("D", 12, "12D.png");
    Card card3 = new Card("C", 13, "13C.png");
    Card card4 = new Card("S", 10, "14S.png");
    Card card5 = new Card("H", 1, "15H.png");
    Hand hand = new Hand();
    SolveWinner solver = new SolveWinner();
    public void TestHand()
    {
        hand.AddCard(card);
        hand.AddCard(card2);
        hand.AddCard(card3);
        hand.AddCard(card4);
        hand.AddCard(card5);

        Console.WriteLine(hand.GetCards());
        Console.WriteLine(solver.IsFlush(hand.GetCards()));// Should be true
    }
    */
    private Deck deck;
    private Hand playerHand;
    private Hand opponentHand;
    private Hand communityCards;


    public void RunGame()
    {
        //TO DO: Add a universal point system. For now we will use these improvised points
        int playerPoints = 100; // points should be available to the player at all times
        deck = new Deck();
        playerHand = new Hand();
        opponentHand = new Hand();
        communityCards = new Hand();
        deck.Shuffle();

        for (int i = 0; i < 2; i++) //deal the cards like a dealer back and forth
        {
            playerHand.AddCard(deck.DealCard());
            opponentHand.AddCard(deck.DealCard());
        }

        //Get the flop (First three community cards in the river)
    communityCards.AddCard(deck.DealCard());
    communityCards.AddCard(deck.DealCard());
    communityCards.AddCard(deck.DealCard()); //TO DO: display the flop

        //Promt the user with a choice to raise, stand, or fold. Player will always go first.

        // Show hands and community cards
        Console.WriteLine("Player Hand: " + playerHand.GetCards());
        Console.WriteLine("Opponent Hand: " + opponentHand.GetCards());
        Console.WriteLine("Community Cards: " + communityCards.GetCards());



        // Determine winner
        SolveWinner solver = new SolveWinner();
        Console.WriteLine(SolveWinner.DetermineWinner(playerHand, opponentHand, communityCards)); //display winner
    }

    public int BetCallFold(int playerPoints, int pot)
    {
        //Promt the user with a choice to raise, stand, or fold. Player will always go first.
        Console.WriteLine("Current Pot: " + pot);
        Console.WriteLine("Player Points: " + playerPoints);
        Console.WriteLine("Choose an action: 1. Raise 2. Call 3. Fold");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice) // Promt user with options
        {
            case 1: // Raise
                Console.WriteLine("Enter amount to raise:");
                int raiseAmount = Convert.ToInt32(Console.ReadLine()); // will refactor to user input
                if (raiseAmount > playerPoints)
                {
                    Console.WriteLine("Insufficient points."); // Show user does not have enough points
                }
                else
                {
                    pot += raiseAmount;
                    playerPoints -= raiseAmount;
                }
                break;
            case 2: // Call
                pot += 10; // Call amount
                playerPoints -= 10;
                break;
            case 3: // Fold
                Console.WriteLine("You folded.");
                break;
            default:
                Console.WriteLine("Invalid choice."); // should not be possible since only three options are presented to user
                break;
        }

        return pot;
    }

}
