using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Domain.Factories;
using System;

namespace DungeonCrawler.Presentation.Views
{
    public static class GameView
    {
        public static Hero ProvideNewHeroFromUserInput()
        {
            Console.WriteLine("Enter Hero name:");
            var name = Console.ReadLine();

            Console.WriteLine("Choose Hero species:");
            Console.WriteLine("0 - Warrior");
            Console.WriteLine("1 - Mage");
            Console.WriteLine("2 - Ranger");

            var speciesValid = false;
            var species = 0;
            while (speciesValid == false)
            {
                speciesValid = int.TryParse(Console.ReadLine(), out species);

                if (speciesValid == false)
                {
                    Console.WriteLine("You inputted invalid species, please repeat your input.");
                }
            }

            return HeroFactory.CreateNew(name, species);
        }

        //@ToDo: multiple games
        public static void ListPlayerStats(Game game)
        {
            Console.WriteLine("\n\n---------Full Stats---------\n");

            Console.WriteLine($"\n" +
                $"Hero [{game.Hero.Name}]\n" +
                $"\tlvl.{game.Hero.Level}\n" +
                $"\tXP: {game.Hero.Experience}\n" +
                $"\tBattles won: {game.Hero.Wins}\n"
                );

            Console.WriteLine($"\n----------------------------");
        }

        public static void PromptResult(Game game)
        {
            if (game.Status == GameStatus.HeroWon)
            {
                Console.WriteLine("Congratulations, your hero won the game!");
            }
            else if (game.Status == GameStatus.HeroLost)
            {
                Console.WriteLine("Bad luck...unfortunately your hero died and lost game.");
            }
            else
            {
                Console.WriteLine("BUG: Game error ocurred, game is over but there was no winner.");
            }
        }

        public static void PlayGame(Game game)
        {
            Console.WriteLine($"Your hero {game.Hero.Name} is starting its Dungeon crawling adventure!");

            game.Status = GameStatus.InPlay;
            var battleCounter = 0;

            while (IsGameOver(game.Status, battleCounter) == false)
            {
                BattleView.DoBattle(game);

                if (game.Status == GameStatus.InPlay && battleCounter >= 10)
                {
                    game.Status = GameStatus.HeroWon;
                }

                battleCounter++;
            }

        }

        public static bool IsTurnedOff()
        {
            Console.WriteLine("\n\nDo you wanna play another game?" +
                "\n0 - Yes" +
                "\n1 - No");


            int.TryParse(Console.ReadLine(), out var gameSwitchInput);
            return gameSwitchInput != 0;
        }

        private static bool IsGameOver(GameStatus gameStatus, int battleCounter)
        {
            return gameStatus == GameStatus.HeroWon || gameStatus == GameStatus.HeroLost || battleCounter >= 10;
        }
    }
}
