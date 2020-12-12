using DungeonCrawler.Data;
using System;

namespace DungeonCrawler.Domain.Factories
{
    public static class BattleFactory
    {
        public static Battle CreateNewIn(Game game)
        {
            return new Battle(game);
        }
    }
}
