using DungeonCrawler.Data.Abstractions;
using System;
using System.Collections.Generic;

namespace DungeonCrawler.Data
{
    public class Battle
    {
        public Hero Hero { get; set; }
        public Monster Monster { get; set; }
        public Character Winner { get; set; }
        public List<Round> Rounds { get; } = new List<Round>();
        public bool IsStunActivated { get; private set; }

        public Battle(Game game, Hero hero, Monster monster)
        {
            game.Battles.Add(this);

            Hero = hero;
            Monster = monster;
        }

        public void ActivateStun()
        {
            IsStunActivated = true;
        }

        public bool HasWinner()
        {
            return Hero.IsDead() || Monster.IsDead();
        }

        public override string ToString()
        {
            return $"\n" +
                $"---------BATTLE---------\n" +
                $"{Hero}\n" +
                $"-----------VS-----------\n" +
                $"{Monster}\n" +
                $"-----------------------\n";
        }
    }
}
