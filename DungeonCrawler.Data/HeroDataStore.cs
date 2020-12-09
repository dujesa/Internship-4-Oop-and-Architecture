using DungeonCrawler.Data.Abstractions;
using System.Collections.Generic;

namespace DungeonCrawler.Data
{
    public static class HeroDataStore
    {
        public static List<Hero> Heroes { get; } = new List<Hero>();
    }
}
