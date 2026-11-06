namespace Blackjack;

public abstract record BlackjackGameAction
{
    public record Hit
    {
        public required PileNumber PileNumber { get; init; }
    }

    public record Stand { }

    public record Split
    {
        public required PileNumber PileNumber { get; init; }
    }

    public record DoubleDown
    {
        public required PileNumber PileNumber { get; init; }
    }
}
