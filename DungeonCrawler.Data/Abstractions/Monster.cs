using DungeonCrawler.Data.Enums;
using DungeonCrawler.Data.Models;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Monster : Character
    {
        public int AppearanceChance { get; protected set; }
    }
}
