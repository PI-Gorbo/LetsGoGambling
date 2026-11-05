namespace Blackjack.Console;

using Spectre.Console;
using static Blackjack.BlackjackGameManager.PerformActionResult;

internal class Program
{
    private static void Main(string[] args)
    {
        AnsiConsole.Write(new FigletText("Blackjack").Color(Color.Purple3));

        var game = BlackjackGameManager.CreateNewGame([
            new Actor.Player("Sam"),
            new Actor.Player("Henry")
        ]);

        var outcome = RunGameInteractively(game);
        if (outcome is GameOutcome.Error error)
        {
            AnsiConsole.WriteLine(error.ErrorMessage);
        }
    }

    private static GameOutcome RunGameInteractively(BlackjackGame game)
    {
        PrintGameToScreen(game);

        while (BlackjackGameManager.IsGameComplete(game) is false)
        {
            var availableActions = BlackjackGameManager.GetAvailableActions(game);
            var choice = ChooseActionFromAvailableActions(availableActions);
            var result = BlackjackGameManager.PerformAction(game, choice)!;

            if (result is InvalidAction error)
            {
                return new GameOutcome.Error(error.ErrorMessage);
            }
            else if (result is UpdatedGame updated)
            {
                game = updated.Game;
                PrintGameToScreen(game);
            }
        }

        return new GameOutcome.Success();
    }

    private static void PrintGameToScreen(BlackjackGame gameState)
    {
        throw new NotImplementedException("I am not implemented");
    }

    private static BlackjackGameAction ChooseActionFromAvailableActions(BlackjackGameAction[] actions)
    {
        throw new NotImplementedException("I am not implemented");
    }
}

public abstract record GameOutcome
{
    public record Success : GameOutcome;
    public record Error(string ErrorMessage) : GameOutcome;
}