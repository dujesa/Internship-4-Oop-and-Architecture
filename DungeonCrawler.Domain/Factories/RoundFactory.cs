using DungeonCrawler.Data;

namespace DungeonCrawler.Domain.Factories
{
    public static class RoundFactory
    {
        public static Round CreateNewIn(Battle battle)
        {
            return new Round(battle);
        }
    }
}
