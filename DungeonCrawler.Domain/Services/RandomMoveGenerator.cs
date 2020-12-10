using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Domain.Factories;
using System;

namespace DungeonCrawler.Domain.Services
{
    public static class RandomMoveGenerator
    {
        public static Move GenerateFor(Monster monster)
        {
            Random random = new Random();
            var randomType = random.Next(0, 3);

            return MoveFactory.CreateNewByTypeFor((MoveType)randomType, monster);
        }
    }
}
