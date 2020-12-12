using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Data.Models.Monsters;
using System;
using System.Collections.Generic;

namespace DungeonCrawler.Data
{
    public class Game
    {
        public Hero Hero { get; set; }
        public List<Monster> Monsters { get; } = new List<Monster>();
        public GameStatus Status { get; set; } = GameStatus.ToBeStarted;
        public Dictionary<int, Battle> Battles { get; } = new Dictionary<int, Battle>();

        public bool IsJumbusActive { get; private set; } = false;

        public Game(Hero hero)
        {
            Hero = hero;
        }
        public void ActivateJumbus()
        {
            IsJumbusActive = true;
        }

        public void DeactivateJumbus()
        {
            IsJumbusActive = false;
        }

        public void AddBattle(Battle battle)
        {
            var newBattleId = Battles.Count;
            Battles.Add(newBattleId, battle);
            battle.SetId(newBattleId);
        }

        public void AddMonsterAfter(Witch witch, Monster newMonster)
        {
            var witchIndex = Monsters.IndexOf(witch);

            if (witchIndex >= 0)
            {
                Monsters.Insert(witchIndex + 1, newMonster);
            }
        }
    }
}
