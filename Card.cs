internal class Card
{
    public Card(string name, CardType cardTypes)
    {
        Name = name;
        CardTypes = cardTypes;
    }

    public string Name { get; }
    public CardType CardTypes { get; }
}