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
        return Cards.Dequeue();
    }

    public void Shuffle()
    {
        PerfectShuffle();
    }


    public void PutBackCards(List<Card> hand)
    {
        while (hand.Count > 0)
        {
            Cards.Enqueue(hand[0]);
            hand.RemoveAt(0);
        }
    }

    public void PerfectShuffle()
    {
        var leftHalf = NumberOfCards() / 2;

        var left = new Queue<Card>();
        var right = new Queue<Card>();
        var i = 0;
        while (i < leftHalf)
        {
            left.Enqueue(DrawCard());
            i++;
        }

        while (Cards.Count > 0) right.Enqueue(DrawCard());

        var getRight = true;

        while (left.Count > 0 || right.Count > 0)
        {
            if (getRight)
            {
                Cards.Enqueue(right.Dequeue());
            }
            else
            {
                Cards.Enqueue(left.Dequeue());
            }

            getRight = !getRight;
        }
    }

    public int NumberOfCards()
    {
        return Cards.Count;
    }

    private void OpenNewPackOfCards()
    {
        foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
        foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
        {
            var newCard = new Card(rank, suit);
            Cards.Enqueue(newCard);
        }
    }
}