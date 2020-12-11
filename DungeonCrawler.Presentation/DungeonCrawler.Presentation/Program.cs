using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Domain.Services;
using DungeonCrawler.Presentation.Views;
using System;

namespace DungeonCrawler.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----DUNGEON CRAWLER GAME-----");

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

            Console.WriteLine($"\n\nYour score was {GameManager.GetNumberOfGamesWon()} games won!" +
                $"\nThanks for playing game.");
        }
    }
}
