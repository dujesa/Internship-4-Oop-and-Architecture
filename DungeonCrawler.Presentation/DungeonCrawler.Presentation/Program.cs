using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Domain.Services;
using DungeonCrawler.Domain.Utils;
using DungeonCrawler.Presentation.Views;

namespace DungeonCrawler.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter.StartGameConsole();

            var isGameTurnedOff = false;

            while (isGameTurnedOff == false)
            {
                Hero hero = GameView.ProvideHero();
                Game game = GameManager.InitializeNewGame(hero);

                GameView.PlayGame(game);

                GameView.PromptResult(game);
                GameView.ListPlayerStats(game);

                isGameTurnedOff = GameView.IsTurnedOff();
            }

            ConsoleWriter.EndGameConsole();
        }
    }
}
