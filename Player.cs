namespace BlackJack;

public class Player : IPlayer
{
    public List<Card> Hand { get; set; } = new();
    public bool Stood { get; set; }

    public int GetScore()
    {
        var score = 0;
        var numAces = 0;
        foreach (var card in Hand)
        {
            score += Util.CardValues[card._rank];
            if (card._rank == Card.Rank.Ace)
            {
                numAces += 1;
            }
        }

        while (score > 21 && numAces > 0)
        {
            score -= 10;
            numAces -= 1;
        }

        return score;
    }

    public void Hit(Deck deck)
    {
        Hand.Add(deck.DrawCard());
    }

    public void Stand()
    {
        Stood = true;
    }

    public string ShowCards()
    {
        var output = "";
        foreach (var card in Hand)
        {
            output += card + ",";
        }

        return output;
    }

    public void PutBackCards(List<Card> hand, Deck deck)
    {
        deck.PutBackCards(Hand);
        Hand.Clear();
    }
}