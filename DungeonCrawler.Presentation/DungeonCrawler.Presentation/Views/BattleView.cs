using DungeonCrawler.Data;
using System;

namespace DungeonCrawler.Presentation.Views
{
    public static class BattleView
    {
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
