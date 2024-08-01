namespace mtg_portent_sim;

class Program
{
    static void Main(string[] args)
    {
        var sim = new PortentSimulation();
        var deck = DeckList.CreateDeck();
        const int manaValueX = 12;
        const int samples = 25000;

        RunSimulation(sim, deck, manaValueX, samples);
    }

    private static void RunSimulation(PortentSimulation sim, Deck deck, int manaValueX, int samples)
    {
        var sumOfTypesAtReveal = new RevealCounter();
        var sumOf4OrMoreTypesAtReveal = new RevealCounter();

        Console.WriteLine($"Running Portent simulation on {deck.Name} ({deck.Count()} cards) where x={manaValueX} over {samples} samples.");

        var allTypes = new CardTypeCounter();
        foreach (var reveal in deck.RevealTop(deck.Count()))
        {
            allTypes.AddTypes(reveal.Card.CardTypes);
        }
        Console.WriteLine(string.Join(", ", allTypes.TypeCounts().Select(kvp => $"{kvp.Key}:{kvp.Value}")));

        for (int i = 0; i < samples; i++)
        {
            var typesAtEachReveal = sim.Run(deck, manaValueX);
            sumOfTypesAtReveal.SumReveals(typesAtEachReveal);
            sumOf4OrMoreTypesAtReveal.IncrementRevealsConditionally(typesAtEachReveal, (double cardTypeCount) => cardTypeCount >= 4);
        }

        Console.WriteLine("(x, Avg. Card Types)");
        foreach (var reveal in sumOfTypesAtReveal.RevealCounters())
        {
            Console.WriteLine($"{reveal.Key}\t{reveal.Value / samples}");
        }

        Console.WriteLine("(x, Prob. of 4 or more types)");
        foreach (var reveal in sumOf4OrMoreTypesAtReveal.RevealCounters())
        {
            Console.WriteLine($"{reveal.Key}\t{reveal.Value / samples}");
        }
    }
}