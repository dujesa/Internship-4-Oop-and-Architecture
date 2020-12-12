using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Models.Monsters;
using DungeonCrawler.Domain.Factories;

namespace DungeonCrawler.Domain.Services
{
    public static class MonsterDeathHandler
    {
        public static int HandleCreationOfNewMonsters(Game game, Monster monster)
        {
            var newMonstersCreated = 0;

            if (monster is Witch witch)
            {
                while (newMonstersCreated < 2)
                {
                    game.AddMonsterAfter(witch, MonsterFactory.CreateRandom());
                    newMonstersCreated++;
                }
            }

            return newMonstersCreated;
        }
    }
}
