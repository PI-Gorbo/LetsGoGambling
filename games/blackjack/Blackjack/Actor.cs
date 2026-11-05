namespace Blackjack;

public abstract record Actor
{
    public record Player(string Name) : Actor;
    public record Dealer : Actor { }
}