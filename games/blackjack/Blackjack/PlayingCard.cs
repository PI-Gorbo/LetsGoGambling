namespace Blackjack;

public record PlayingCard
{
    public required Suit Suit { get; init; }
    public required Rank Rank { get; init; }
}

public record Deck
{
    public required List<PlayingCard> Cards { get; init; }

    public static Deck CreateDeck()
    {
        var suits = Enum.GetValues<Suit>();
        var ranks = Enum.GetValues<Rank>();
        var cards = suits
            .SelectMany(suit => ranks.Select(rank => (suit, rank)))
            .Select((pair) => new PlayingCard()
            {
                Rank = pair.rank,
                Suit = pair.suit
            }).ToList();

        return new Deck()
        {
            Cards = cards
        };
    }

    public Deck Shuffle()
    {
        throw new NotImplementedException();
    }
}