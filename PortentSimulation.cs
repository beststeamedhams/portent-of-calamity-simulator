internal class PortentSimulation
{
    public RevealCounter Run(Deck deck, int x) // Where x is x on Portent of Calamity
    {
        var types = new CardTypeCounter();
        var reveals = new RevealCounter();

        deck.Shuffle();
        foreach (var reveal in deck.RevealTop(x))
        {
            types.AddTypes(reveal.Card.CardTypes);
            reveals.SetCounter(reveal.Position, types.Count());
        }

        return reveals;
    }
}