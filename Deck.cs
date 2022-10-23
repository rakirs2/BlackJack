namespace BlackJack;

public class Deck : IDeck
{
    internal Deck()
    {
        OpenNewPackOfCards();
    }

    private Queue<Card> Cards { get; } = new();

    public Card DrawCard()
    {
        throw new NotImplementedException();
    }

    public void Shuffle()
    {
        throw new NotImplementedException();
    }

    public void ResetDeck()
    {
    }

    private void OpenNewPackOfCards()
    {
        foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
        foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
        {
            var newCard = new Card(rank, suit);
            Console.WriteLine(newCard);
            Cards.Enqueue(newCard);
        }
    }
}