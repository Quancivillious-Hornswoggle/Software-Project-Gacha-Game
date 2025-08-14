using Software_Project_Gacha_Game;
using Software_Project_Gacha_Game.GameLibraries.Blackjack;
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

    public Blackjack()
    {
        deck = new Deck();
        playerHand = new Hand();
        dealerHand = new Hand();
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

    public void PlayerHits()
    {
        if (!gameActive) return;
        playerHand.AddCard(deck.DealCard());

        if (playerHand.GetHandValue() > 21)
        {
            Console.WriteLine("Player busts! Dealer wins!");
            gameActive = false;
        }
    }

    public void PlayerStands()
    {
        if (!gameActive) return;

        while (dealerHand.GetHandValue() < 17)
        {
            dealerHand.AddCard(deck.DealCard());
        }

        int playerValue = playerHand.GetHandValue();
        int dealerValue = dealerHand.GetHandValue();

        if (dealerValue > 21 || playerValue > dealerValue)
        {
            Console.WriteLine("Player wins!");
        }
        else if (playerValue < dealerValue)
        {
            Console.WriteLine("Dealer wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
        gameActive = false;
    }

    public Hand GetPlayerHand() => playerHand;
    public Hand GetDealerHand() => dealerHand;
    public bool IsGameActive() => gameActive;
}



