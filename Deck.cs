internal class Deck
{
    private IList<Card> _cards = new List<Card>(60);

    public Deck(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public int Count() => _cards.Count;

    public void AddCard(int copies, Card card)
    {
        for (int i = 0; i < copies; i++)
        {
            _cards.Add(card);
        }
    }

    public IEnumerable<RevealedCard> RevealTop(int count)
    {
        return _cards.Select((value, index) => new RevealedCard(value, index + 1)).Take(count);
    }

    public void Shuffle()
    {
        // https://stackoverflow.com/questions/273313/randomize-a-listt
        var rng = new Random();
        int n = _cards.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = _cards[k];
            _cards[k] = _cards[n];
            _cards[n] = value;
        }
    }
}

internal class RevealedCard {
    public RevealedCard(Card card, int position) {
        Card = card;
        Position = position;
    }

    public Card Card { get; }
    public int Position { get; }
}