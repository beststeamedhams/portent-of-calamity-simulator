[Flags]
internal enum CardType
{
    Land = 1,
    Creature = 2,
    Artifact = 4,
    Enchantment = 8,
    Sorcery = 16,
    Instant = 32,
    Planeswalker = 64,
    Battle = 128,
    Kindred = 256,
}