using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Models;

namespace DungeonCrawler.Domain.Factories
{
    public class HeroFactory
    {
        public const int Warrior = 0;
        public const int Mage = 1;
        public const int Ranger = 2;

        public static Hero CreateNew(string name, int heroSpecies)
        {

            if (heroSpecies == Mage)
            {
                return new Mage(name);
            }

            if (heroSpecies == Warrior)
            {
                return new Ranger(name);
            }

            return new Warrior(name);
        }
    }
}
