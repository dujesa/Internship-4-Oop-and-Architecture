using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Domain.Factories;
using DungeonCrawler.Domain.Services;
using System;

namespace DungeonCrawler.Presentation.Views
{
    public static class BattleView
    {
        public static void DoBattle(Game game)
        {
            Battle battle = BattleFactory.CreateNewIn(game);

            Console.WriteLine($"Starting battle\n" +
                $" {battle}\n");

            while (battle.HasWinner() == false)
            {
                //battle-rounds logic
                RoundView.PlayRound(battle);
            }

            BattleManager.ProvideWinner(battle);

            if (battle.Winner is Monster)
            {
                game.Status = GameStatus.HeroLost;
            }

            Console.WriteLine($"\nBattle beetween {battle.Hero} and {battle.Monster} is finished." +
                $"\nWinner is: {battle.Winner}" +
                $"\n");
        }

        public static void ListStats(Game game)
        {
            Console.WriteLine("\n\n---------Game Stats---------\n");

            foreach (var battle in game.Battles)
            {
                Console.WriteLine($"\n" +
                    $"Battle [vs {battle.Monster.GetType()}]" +
                    $"Winner: {battle.Winner}" +
                    $"Rounds: {battle.Rounds.Count}\n");
                //left hp of hero?, similar to bite fight
            }

            Console.WriteLine($"\n----------------------------");
        }
    }
}
