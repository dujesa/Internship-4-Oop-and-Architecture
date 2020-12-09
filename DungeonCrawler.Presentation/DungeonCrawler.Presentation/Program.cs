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

            Hero hero = GameView.ProvideNewHeroFromUserInput();
            Game game = GameManager.InitializeNewGame(hero);

            var isWon = GameView.PlayGame(game);

            GameView.PromptResult(isWon);
            GameView.ListPlayerStats(game);
            

            Console.WriteLine("Thanks for playing game!");
        }
    }
}
