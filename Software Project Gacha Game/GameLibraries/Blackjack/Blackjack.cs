using Software_Project_Gacha_Game;
using Software_Project_Gacha_Game.GameLibraries.CardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Blackjack
    {
    private Deck deck;
    private Hand playerHand;
    private Hand dealerHand;
    private bool gameActive;

    //money money
    public static float playerBalance = 1000f;
    public static float betAmount;

    public Blackjack()
    {
        deck = new Deck();
        playerHand = new Hand();
        dealerHand = new Hand();
    }

    public static void PlaceBet(float wager)
    {
        if (wager <= 0) throw new ArgumentException("Bet must be positive.");
        if (wager >playerBalance) throw new ArgumentException("Not enough funds to place this bet.");
    
    betAmount = wager;
    playerBalance -= wager;
    }

    public static float GetBalance()
    {
        return playerBalance;
    }


    public void DealInitialCards()
    {
        dealerHand.AddCard(deck.DealCard());
        playerHand.AddCard(deck.DealCard());
        playerHand.AddCard(deck.DealCard());
    }

    public void StartGame()
    {
        deck.Shuffle();
        playerHand.ClearHand();
        dealerHand.ClearHand();
        DealInitialCards();
        gameActive = true;

        Console.WriteLine("Game started. Player and dealer have been dealt cards.");
    }

    public bool PlayerHits()
    {
        // Return if busted or not 
        if (gameActive)
        {
            playerHand.AddCard(deck.DealCard());
            if (playerHand.GetHandValue() > 21)
            {
                Console.WriteLine("Player busts! Dealer wins!");
                gameActive = false;
                return true;
            }
        }
        return false;

        /*if (!gameActive) return;
        playerHand.AddCard(deck.DealCard());

        if (playerHand.GetHandValue() > 21)
        {
            Console.WriteLine("Player busts! Dealer wins!");
            gameActive = false;
        }*/
    }

    public int PlayerStands()
    {
        if (gameActive) {
            while (dealerHand.GetHandValue() < 17)
            {
                dealerHand.AddCard(deck.DealCard());
            }

            int playerValue = playerHand.GetHandValue();
            int dealerValue = dealerHand.GetHandValue();

            if (dealerValue > 21 || playerValue > dealerValue)
            {
                Console.WriteLine("Player wins!");
                gameActive = false;
                return 0;
            }
            else if (playerValue < dealerValue)
            {
                Console.WriteLine("Dealer wins!");
                gameActive = false;
                return 1;
            }
            else
            {
                Console.WriteLine("It's a tie!");
                gameActive = false;
                return 2;
            }
        }
        return -1;
    }

    public Hand GetPlayerHand() => playerHand;
    public Hand GetDealerHand() => dealerHand;
    public bool IsGameActive() => gameActive;
}



