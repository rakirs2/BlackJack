using System.ComponentModel;

namespace BlackJack;

public class BlackJackGame
{
    public Player player { get; }
    public Dealer dealer { get; }
    public Deck deck { get; }

    public BlackJackGame(Player player, Dealer dealer)
    {
        this.player = player;
        this.dealer = dealer;
        Console.WriteLine("Starting with a new deck");
        deck = new Deck();
    }

    public void InitialDeals()
    {
        player.Hit(deck);
        dealer.Hit(deck);
        player.Hit(deck);
        dealer.Hit(deck);

        Console.WriteLine(player.ShowCards());
        Console.WriteLine(player.GetScore());
        Console.WriteLine(dealer.GetScore());
    }
}