namespace BlackJack;

public class Card
{
    public enum Rank
    {
        Ace,
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
        Club,
        Heart,
        Diamond
    }

    internal Card(Rank rank, Suit suit)
    {
        _suit = suit;
        _rank = rank;
    }

    public Suit _suit { get; }
    public Rank _rank { get; }

    public override string ToString()
    {
        return $"{_rank} of {_suit}s";
    }
}