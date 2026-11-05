namespace Blackjack;

public static class BlackjackGameManager
{
    public static BlackjackGame CreateNewGame(Actor.Player[] players)
    {
        throw new NotImplementedException("Implement Me");
    }

    public abstract record PerformActionResult
    {
        public record UpdatedGame(BlackjackGame Game) : PerformActionResult;
        public record InvalidAction(string ErrorMessage) : PerformActionResult;
    }

    public static PerformActionResult PerformAction(BlackjackGame gameState, BlackjackGameAction action)
    {
        throw new NotImplementedException("Implement me");
    }

    public static BlackjackGameAction[] GetAvailableActions(BlackjackGame gameState)
    {
        throw new NotImplementedException("Implement me");
    }

    public static bool IsGameComplete(BlackjackGame gameState)
    {
        throw new NotImplementedException("Implement me");
    }

    public static Actor GetCurrentActor(BlackjackGame gameState)
    {
        throw new NotImplementedException("Implement me");
    }
}

