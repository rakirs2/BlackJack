namespace BlackJack;

public interface IDeck
{
    public Card DrawCard();
    public void Shuffle();
    public void PutBackCards(List<Card> hand);
    public void PerfectShuffle();
    public int NumberOfCards();
}