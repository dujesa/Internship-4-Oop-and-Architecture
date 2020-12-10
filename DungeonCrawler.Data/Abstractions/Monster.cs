using System;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Monster : Character
    {
        public int XpAward { get; protected set; }
        public int AppearanceChance { get; protected set; }
    }
}
