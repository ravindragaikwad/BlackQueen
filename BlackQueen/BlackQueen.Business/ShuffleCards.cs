using BlackQueen.Entities;

namespace BlackQueen.Business;

public static class ShuffleCards
{
    public static List<Card> Shuffle()
    {
        List<Card> cards = new List<Card>();

        cards.Add(new Card(1, "Ace"));
        cards.Add(new Card(2, "2"));
        cards.Add(new Card(3, "3"));
        cards.Add(new Card(4, "4"));
        cards.Add(new Card(5, "5"));
        cards.Add(new Card(6, "6"));
        cards.Add(new Card(7, "7"));
        cards.Add(new Card(8, "8"));
        cards.Add(new Card(9, "9"));
        cards.Add(new Card(10, "10"));
        cards.Add(new Card(11, "Jack"));
        cards.Add(new Card(12, "Queen"));
        cards.Add(new Card(13, "King"));

        Random rand = new Random();
        var shuffled = cards.OrderBy(_ => rand.Next()).ToList();
        return shuffled;
    }
}