namespace Blackjack;

public abstract record BlackjackGameAction
{
    public record Hit { }
    public record Stand { }
    public record Split { }
    public record DoubleDown { }
}
