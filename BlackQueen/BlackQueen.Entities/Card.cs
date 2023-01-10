namespace BlackQueen.Entities;
public class Card
{
    public Card(int _cardID, string _cardName)
    {
        this.cardId = _cardID;
        this.cardName = _cardName;
    }

    public int cardId { get; set; }
    public string? cardName { get; set; }
}

