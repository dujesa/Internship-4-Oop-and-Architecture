using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using System.Collections.Generic;

namespace DungeonCrawler.Data
{
    public class Game
    {
        public Hero Hero { get; set; }
        public List<Monster> Monsters { get; } = new List<Monster>();
        public GameStatus Status { get; set; } = GameStatus.ToBeStarted;
        public List<Battle> Battles { get; } = new List<Battle>();

        public Game(Hero hero)
        {
            Hero = hero;
        }
    }
}
