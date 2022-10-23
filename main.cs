using BlackJack;

var deck = new Deck();

deck.PerfectShuffle();
while (deck.NumberOfCards()>0)
{
    Console.WriteLine(deck.DrawCard());
}