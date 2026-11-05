namespace Blackjack.Console;

using System.Diagnostics;
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

        var outcome = RunGame(game);

        if (outcome is GameOutcome.Error error)
        {
            AnsiConsole.WriteLine(error.ErrorMessage);
        }
    }

    private static GameOutcome RunGame(BlackjackGame game)
    {
        PrintGameToScreen(game);

        if (BlackjackGameManager.IsGameComplete(game))
        {
            return new GameOutcome.Success();
        }

        var choice = ChooseActionFromAvailableActions(BlackjackGameManager.GetAvailableActions(game));

        return BlackjackGameManager.PerformAction(game, choice) switch
        {
            UpdatedGame updated => RunGame(updated.Game), // play the next turn with the new game
            InvalidAction error => new GameOutcome.Error(error.ErrorMessage),
            _ => throw new UnreachableException()
        };
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