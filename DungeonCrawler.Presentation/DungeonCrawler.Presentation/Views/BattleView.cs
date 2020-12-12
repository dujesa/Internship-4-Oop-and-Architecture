using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Data.Models.Heroes;
using DungeonCrawler.Domain.Factories;
using DungeonCrawler.Domain.Services;
using System;

namespace DungeonCrawler.Presentation.Views
{
    public static class BattleView
    {
        public static void DoBattle(Game game, int? retryBattleId)
        {
            var battle = ProvideBattle(game, retryBattleId);

            Console.WriteLine($"Starting battle\n" +
                $" {battle}\n");

            while (!battle.HasWinner())
            {
                RoundView.PlayRound(game, battle);
            }

            BattleManager.ProvideWinner(battle);

            Console.WriteLine($"\nBattle beetween {battle.Hero} and {battle.Monster} is finished.\n");

            if (battle.Winner is Hero hero)
            {
                var xpAward = battle.Monster.XpAward;
                hero.ExperienceUp(xpAward);

                Console.WriteLine($"Congratulations, your hero has won battle and gained {xpAward}\n\n");
                hero.AwardForBattleWin();

                var newMonstersCreated = MonsterDeathHandler.HandleCreationOfNewMonsters(game, battle.Monster);

                if (newMonstersCreated > 0) Console.WriteLine($"*!*!*!*!*! On its death, monster just created {newMonstersCreated} new monsters !*!*!*!*!*");

                return;
            }

            if (battle.Hero is Mage mage && mage.Resurrect())
            {
                DoBattle(game, battle.Id);

                return;
            }



            if (battle.Winner is Monster)
            {
                game.Status = GameStatus.HeroLost;
                Console.WriteLine("Unfortunately your hero lost.\n");
            }
        }

        private static Battle ProvideBattle(Game game, int? retryBattleId)
        {
            if (retryBattleId == null)
            {
                return BattleFactory.CreateNewIn(game);
            }

            return game.Battles[(int)retryBattleId];
        }

        public static void ListStats(Game game)
        {
            Console.WriteLine("\n\n---------Game Stats---------\n");

            foreach (var (_, battle) in game.Battles)
            {
                Console.WriteLine($"\n" +
                    $"Battle [vs {battle.Monster.GetType()}]" +
                    $"Winner: {battle.Winner}" +
                    $"Rounds: {battle.Rounds.Count}\n");
            }

            Console.WriteLine($"\n----------------------------");
        }
    }
}
