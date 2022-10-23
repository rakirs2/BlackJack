using System.Runtime.InteropServices.ComTypes;

namespace BlackJack;

public static class Util
{
    
    //TODO.Srikar how to add this statically. I only want one instance period.
    public static readonly Dictionary<Card.Rank, int> CardValues = new Dictionary<Card.Rank, int>()
    {
        {Card.Rank.Ace, 11},
        {Card.Rank.Two, 2},
        {Card.Rank.Three, 3},
        {Card.Rank.Four, 4},
        {Card.Rank.Five, 5},
        {Card.Rank.Six, 6},
        {Card.Rank.Seven, 7},
        {Card.Rank.Eight, 8},
        {Card.Rank.Nine, 9},
        {Card.Rank.Ten, 10},
        {Card.Rank.Jack, 10},
        {Card.Rank.Queen, 10},
        {Card.Rank.King, 10},

    };
}