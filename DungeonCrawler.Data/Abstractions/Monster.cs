using System;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Monster : Character
    {
        public int AppearanceChance { get; protected set; }
    }
}
