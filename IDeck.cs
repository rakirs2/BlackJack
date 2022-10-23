namespace BlackJack;

public interface IDeck
{
    public Card DrawCard();
    public void Shuffle();
    public void ResetDeck();
}