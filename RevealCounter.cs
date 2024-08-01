using System.Collections.Immutable;

internal class RevealCounter
{
    private IDictionary<int, double> _counter = new Dictionary<int, double>();

    public ImmutableDictionary<int, double> RevealCounters()
    {
        return _counter.ToImmutableDictionary();
    }

    public void SetCounter(int revealPosition, int value)
    {
        _counter[revealPosition] = value;
    }

    public void SumReveals(RevealCounter other)
    {
        foreach (var kvp in other._counter)
        {
            _counter[kvp.Key] =
                _counter.TryGetValue(kvp.Key, out var existingValue)
                ? existingValue + kvp.Value
                : kvp.Value;
        }
    }

    internal void IncrementRevealsConditionally(RevealCounter other, Func<double, bool> condition)
    {
        foreach (var kvp in other._counter)
        {
            if (condition(kvp.Value))
            {
                _counter[kvp.Key] =
                _counter.TryGetValue(kvp.Key, out var existingValue)
                ? existingValue + 1
                : 1;
            }
        }
    }
}