namespace BlackJack;

public class Dealer : Player
{
    private void DefaultDealerLogic(Deck deck)
    {
        if (GetScore() >= 17)
        {
            Stand();
        }
        else
        {
            Hit(deck);
        }
    }

    private void dealCardToPlayer(Deck deck, Player player)
    {
        var card = deck.DrawCard();
        player.Hand.Add(card);
    }
}