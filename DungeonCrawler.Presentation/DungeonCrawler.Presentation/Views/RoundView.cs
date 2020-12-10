using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Domain.Factories;
using DungeonCrawler.Domain.Services;
using System;

namespace DungeonCrawler.Presentation.Views
{
    public static class RoundView
    {
        public static void PlayRound(Battle battle)
        {
            Round round = RoundFactory.CreateNewIn(battle);

            if (round.IsStunRound)
            {
                AttackExecutor.Execute(battle.Hero, battle.Monster);

                return;
            }

            Console.WriteLine("\nPlease choose move for this round (choose wisely!):" +
                "\n0. Direct attack" +
                "\n1. Side attack" +
                "\n2. Counter attack" +
                "\n");

            var isMoveValid = false;
            int chosenMoveType = 0;
            while (isMoveValid == false)
            {
                int.TryParse(Console.ReadLine(), out chosenMoveType);

                if (chosenMoveType == (int)MoveType.DirectAttack ||
                    chosenMoveType == (int)MoveType.SideAttack ||
                    chosenMoveType == (int)MoveType.CounterAttack)
                {
                    isMoveValid = true;
                }
                else
                {
                    Console.WriteLine("\nWrong move input, please try again.\n");
                }
            }

            Move heroMove = MoveFactory.CreateNewByTypeFor((MoveType)chosenMoveType, battle.Hero);
            Move monsterMove = RandomMoveGenerator.GenerateFor(battle.Monster);

            Console.WriteLine($"\n[Move battle: Hero - {heroMove} VS Monster - {monsterMove}]\n");

            var roundWinner = MoveHandler.Handle(heroMove, monsterMove);

            if (roundWinner is Hero hero)
            {
                Console.WriteLine("Hero won in move battle and attacks monster.");
                hero.Attack(battle.Monster);
            }
            else if (roundWinner is Monster monster)
            {
                Console.WriteLine("Monster won in move battle and attacks hero.");
                monster.Attack(battle.Hero);
            }
            else
            {
                Console.WriteLine("Move battle ended with draw and no one attacks in this round.");
            }

            //6. Display battle situation
            Console.WriteLine($"\n\n{battle}\n\n");
        }
    }
}
