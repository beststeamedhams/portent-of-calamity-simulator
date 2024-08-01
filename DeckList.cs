internal static class DeckList
{
    public static Deck CreateDeck()
    {
        var deck = new Deck("Calamity Tron (https://www.moxfield.com/decks/67ML1sB8hkOQBm66PmKn6g)");

        // Land
        deck.AddCard(2, new Card("Island", CardType.Land));
        deck.AddCard(3, new Card("Ugin's Labyrinth", CardType.Land));
        deck.AddCard(4, new Card("Urza's Mine", CardType.Land));
        deck.AddCard(4, new Card("Urza's Power Plant", CardType.Land));
        deck.AddCard(4, new Card("Urza's Tower ", CardType.Land));
        deck.AddCard(4, new Card("Urza's Saga", CardType.Enchantment | CardType.Land));

        // Artifact
        deck.AddCard(4, new Card("Expedition Map", CardType.Artifact));
        deck.AddCard(3, new Card("Talisman of Curiosity", CardType.Artifact));
        deck.AddCard(2, new Card("The One Ring", CardType.Artifact));

        // Creature
        deck.AddCard(3, new Card("Cityscape Leveler", CardType.Artifact | CardType.Creature));
        deck.AddCard(1, new Card("Emrakul, the Promised End", CardType.Creature));
        deck.AddCard(2, new Card("Nulldrifter", CardType.Creature));
        deck.AddCard(2, new Card("Ulamog, the Ceaseless Hunger", CardType.Creature));

        // Sorcery
        deck.AddCard(3, new Card("All is Dust", CardType.Kindred | CardType.Sorcery));
        deck.AddCard(4, new Card("Portent of Calamity", CardType.Sorcery));

        // Enchantment
        deck.AddCard(2, new Card("Dress Down", CardType.Enchantment));

        // Instant
        deck.AddCard(4, new Card("Kozilek's Command", CardType.Kindred | CardType.Instant));
        deck.AddCard(1, new Card("Sink into Stupor", CardType.Instant));
        deck.AddCard(2, new Card("Ugin's Binding", CardType.Instant));

        // Planeswalker
        deck.AddCard(4, new Card("Karn Liberated", CardType.Planeswalker));
        deck.AddCard(1, new Card("Karn, the Great Creator", CardType.Planeswalker));
        deck.AddCard(1, new Card("Ugin, the Spirit Dragon", CardType.Planeswalker));

        return deck;
    }
}