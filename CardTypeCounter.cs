using System.Collections.Immutable;

internal class CardTypeCounter
{
    private IDictionary<CardType, int> _bucket = new Dictionary<CardType, int>();

    public CardTypeCounter()
    {
        Clear();
    }

    public void AddTypes(CardType cardTypes)
    {
        foreach (CardType cardType in Enum.GetValues(cardTypes.GetType()))
            if (cardTypes.HasFlag(cardType))
                _bucket[cardType]++;
    }

    public ImmutableDictionary<CardType, int> TypeCounts()
    {
        return _bucket.ToImmutableDictionary();
    }

    public int Count() => _bucket.Where(kvp => kvp.Value >= 1).Count();

    private void Clear()
    {
        foreach (CardType cardType in Enum.GetValues(typeof(CardType)))
            _bucket[cardType] = 0;
    }
}