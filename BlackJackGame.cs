using System.ComponentModel;

namespace BlackJack;

public class BlackJackGame
{
    public List<Player> Players { get; set; }
    public Dealer dealer { get; }

    private BlackJackGame(int numberOfPlayers)
    {
    }
}