namespace BlackJack;

public interface IPlayer
{
    List<Card> Hand { get; set; }
    bool Stood { get; set; }
    int GetScore();
    void Hit(Deck deck);
    void Stand();
    string ShowCards();

    void PutBackCards(List<Card> hand, Deck deck);
}