using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibraries.Poker;

class Poker
{
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
        Console.WriteLine(solver.IsFlush(hand.GetCards()));
    }
}
