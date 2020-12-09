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
                $"\tXP: {game.Hero.Experience}\n"
                //$"\tBattles won: {game.Hero.Wins}\n"
                );

            foreach (var hero in game.Battles)
            {
                //left hp of hero?, similar to bite fight
            }

            Console.WriteLine($"\n----------------------------");
        }

        public static void PromptResult(bool isWon)
        {
            if (isWon)
            {
                Console.WriteLine("Congratulations, your hero won the game!");
            }
            else
            {
                Console.WriteLine("Bad luck...unfortunately your hero died and lost game.");
            }
        }

        public static bool PlayGame(Game game)
        {
            Console.WriteLine($"Your hero {game.Hero.Name} is starting its Dungeon crawling adventure!");

            var battleCounter = 0;

            while (IsGameOver(game.Status, battleCounter) == false)
            {
                Battle battle = new Battle(game, game.Hero, game.Monsters[battleCounter]);
                Console.WriteLine($"TESTNI ISPIS: Startam bitku {battle}\n");
                //@toDo: battle logic
                /*var battleWinner = battleManager.ExecuteBattle(battle);

                if (battleWinner is Monster)
                {
                    game.Status = GameStatus.HeroLost;
                }

                if (battleWinner is Hero)
                {
                    game.Status = GameStatus.HeroWon;
                }*/
                battleCounter++;
            }

            return game.Status == GameStatus.HeroWon;
        }

        private static bool IsGameOver(GameStatus gameStatus, int battleCounter)
        {
            return gameStatus == GameStatus.HeroWon || gameStatus == GameStatus.HeroLost || battleCounter >= 10;
        }
    }
}
