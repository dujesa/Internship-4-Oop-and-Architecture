using DungeonCrawler.Data.Enums;
using System;

namespace DungeonCrawler.Data.Models
{
    public class HealthPoints
    {
        public int Max { get; }
        public int Current { get; set; }

        public HealthPoints()
        { 
            Max = (int)CharactersInfo.InitialHp;
        }

        public HealthPoints(int max)
        {
            Max = max;
        }

        public void LevelUp(int nextLevel)
        {
            throw new NotImplementedException();
        }
    }
}
