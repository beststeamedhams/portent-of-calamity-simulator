# portent-of-calamity-simulator
Simulates Portent of Calamity using the Monte Carlo method.

By default, it will run 25,000 simulations drawing 12 cards off the top of your library.

Sample Output:
```
Running simulation on Calamity Tron (https://www.moxfield.com/decks/67ML1sB8hkOQBm66PmKn6g) (60 cards) where x=12 over 25000 samples.
Land:21, Creature:8, Artifact:12, Enchantment:6, Sorcery:7, Instant:7, Planeswalker:6, Battle:0, Kindred:7
(x, Avg. Card Types)
1	1.23316
2	2.244
3	3.08468
4	3.783
5	4.38496
6	4.88016
7	5.31332
8	5.6826
9	6.00788
10	6.28504
11	6.5282
12	6.73756
(x, Prob. of 4 or more types)
2	0.03576
3	0.31124
4	0.60768
5	0.79512
6	0.8974
7	0.95104
8	0.97632
9	0.98908
10	0.99496
11	0.99784
12	0.99924
```

# Creating a deck
Modify DeckList.cs with cards and card types for the deck to simulate.

Due to the complexity of certain cards (e.g. Grist, the Hunger Tide), you need to manually enter the card types.

Card types are defined by https://mtg.fandom.com/wiki/Card_type

# Prerequisite
NET8 SDK or higher

# Build & Run
Build and run using your favorite IDE or by command line by navigating to the root and running
```
dotnet build
./bin/Debug/net8.0/mtg-portent-sim.exe
```