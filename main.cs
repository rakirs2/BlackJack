using BlackJack;

Console.WriteLine("This is 1 Player BlackJack. Your goal is to beat the dealer");

var player = new Player();
var dealer = new Dealer();
var blackJackGame = new BlackJackGame(player, dealer);
blackJackGame.InitialDeals();

while ((player.GetScore() < 21) & !player.Stood)
{
    Console.WriteLine();
}