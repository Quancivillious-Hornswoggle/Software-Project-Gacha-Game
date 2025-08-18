using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Tar;
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
    private int playerPoints = 100;

    public Poker()
    {
        deck = new Deck();
        playerHand = new Hand();
        opponentHand = new Hand();
        communityCards = new Hand();
    }


    public void RunGame()
    {
        //TO DO: Add a universal point system. For now we will use these improvised points
     // points should be available to the player at all times
    // Example usage to avoid warning:
    Console.WriteLine($"Player starts with {playerPoints} points.");
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

        //Promt the user with a choice to raise, stand, or fold. Player will always go first.
        PlayerChoices playerChoice = BetCallFold(0); // Initial pot is 0 (if no one bets then the players just want to see the flop)
        int pot = 0;
        int opponentRaise = 0;
        int playerRaise = 0;
        switch (playerChoice)
        {
            case PlayerChoices.Raise:
                playerRaise = Bet();
                pot += playerRaise;
                break;
            case PlayerChoices.Call:
                if (Call(pot, opponentRaise) == -1)
                {
                    pot += playerPoints;
                    playerPoints = 0; // Player goes all in
                    Console.WriteLine("Player goes all in!");
                    break;
                }
                pot = Call(pot, opponentRaise);
                
                break;
            case PlayerChoices.Fold:
                opponentRaise = Fold();
                break;
        }

        //Get the flop (First three community cards in the river)
        communityCards.AddCard(deck.DealCard());
        communityCards.AddCard(deck.DealCard());
        communityCards.AddCard(deck.DealCard()); //TO DO: display the flop

        // Show hands and community cards
        Console.WriteLine("Player Hand: " + playerHand.GetCards());
        Console.WriteLine("Opponent Hand: " + opponentHand.GetCards());
        Console.WriteLine("Community Cards: " + communityCards.GetCards());



        // Determine winner
        SolveWinner solver = new SolveWinner();
        Console.WriteLine(SolveWinner.DetermineWinner(playerHand, opponentHand, communityCards)); //display winner
    }

    private PlayerChoices BetCallFold(int pot)
    {
        //Promt the user with a choice to raise, stand, or fold. Player will always go first.
        Console.WriteLine("Current Pot: " + pot);
        Console.WriteLine("Player Points: " + playerPoints);
        Console.WriteLine("Choose an action: 1. Raise 2. Call 3. Fold");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice) // Promt user with options
        {
            case 1: // Raise
            if (playerPoints > 0)
                return PlayerChoices.Raise;
                else
                    Console.WriteLine("Insufficient points."); // Show user does not have enough points
                break;
            case 2: // Call
                return PlayerChoices.Call;
            case 3: // Fold
                return PlayerChoices.Fold;
            default:
                Console.WriteLine("Invalid choice."); // should not be possible since only three options are presented to user
                break;
        }

        return PlayerChoices.Fold;
    }

    private int Bet()
    {
        Console.WriteLine("Enter amount to raise:");
        int raiseAmount = Convert.ToInt32(Console.ReadLine()); // will refactor to user input
        if (raiseAmount > playerPoints)
        {
            Console.WriteLine("Insufficient points."); // Show user does not have enough points
        }
        else
        {
            playerPoints -= raiseAmount;
        }
        return raiseAmount;
    }

    private int Call(int pot, int opponentPoints)
    {
        if (opponentPoints > playerPoints)
        {
            return -1; //Handle as an (ALL IN)
        }

        pot += opponentPoints;
        playerPoints -= opponentPoints;
        return pot;
    }

    private static int Fold()
    {
        Console.WriteLine("You folded.");// show folded message
                                         // Player forfeits the current pot, no points are added or removed
                                         // Optionally, you can return the pot to the opponent or reset it

        return 0;
    }
    
    private enum PlayerChoices
    {
        Raise,
        Call,
        Fold
    }

}
