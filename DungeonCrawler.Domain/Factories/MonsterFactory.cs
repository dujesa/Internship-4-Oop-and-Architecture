using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Data.Models;
using System;

namespace DungeonCrawler.Domain.Factories
{
    public static class MonsterFactory
    {
        private const int Goblin = 0;
        private const int Brute = 1;
        private const int Witch = 2;

        public static Monster CreateRandom()
        {
            var monsterSpecies = GetRandomMonsterSpecies();

            if (monsterSpecies == Brute)
            {
                return new Brute();
            }

            if (monsterSpecies == Witch)
            {
                return new Witch();
            }

            return new Goblin();
        }

        private static int GetRandomMonsterSpecies()
        {
            Random random = new Random();
            var randomNumber = random.Next(0, 100);
            var monsterChance = (int)MonstersInfo.GoblinAppearanceChance;

            if (randomNumber < monsterChance)
            {
                return Goblin;
            }

            monsterChance += (int)MonstersInfo.BruteAppearanceChance;

            if (randomNumber < monsterChance)
            {
                return Brute;
            }

            return Witch;
        }
    }
}
