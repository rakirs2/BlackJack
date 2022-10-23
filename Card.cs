namespace BlackJack;

public class Card
{
    public enum Rank
    {
        Ace,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum Suit
    {
        Spade,
        Diamond,
        Club,
        Heart
    }

    internal Card(Rank rank, Suit suit)
    {
        _suit = suit;
        _rank = rank;
    }

    private Suit _suit { get; }
    private Rank _rank { get; }

    public override string ToString()
    {
        return $" {_rank} of {_suit}s";
    }
}