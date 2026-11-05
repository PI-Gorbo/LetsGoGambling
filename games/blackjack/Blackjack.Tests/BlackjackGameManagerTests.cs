using Shouldly;

namespace Blackjack.Tests;

public class BlackjackGameManagerTests
{
    [Fact]
    public void CanCreateAGameWithOnePlayer()
    {
        BlackjackGame game = BlackjackGameManager.CreateNewGame([
            new Actor.Player("Sam")
        ]);

        game.ShouldNotBeNull();
    }
}
