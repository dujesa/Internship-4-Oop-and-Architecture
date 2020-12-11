using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using System;
using System.Collections.Generic;

namespace DungeonCrawler.Data
{
    public class Game
    {
        public Hero Hero { get; set; }
        public List<Monster> Monsters { get; } = new List<Monster>();
        public GameStatus Status { get; set; } = GameStatus.ToBeStarted;
        public List<Battle> Battles { get; } = new List<Battle>();
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
    }
}
