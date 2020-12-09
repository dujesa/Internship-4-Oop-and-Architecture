using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Domain.Utils;

namespace DungeonCrawler.Domain.Services
{
    public class HeroManager
    {
        public void RaiseExperience(Hero hero, int xpGained)
        {
            hero.Experience += xpGained;

            if (hero.Experience < (HeroLevelDataProvider.GetXpNeededForLevel(hero.Level)))
            {
                return;
            }

            LevelUp(hero);
        }

        private void LevelUp(Hero hero)
        {
            int nextLevel = hero.Level + 1;

            hero.Experience -= HeroLevelDataProvider.GetXpNeededForLevel(nextLevel);
            hero.Damage += HeroLevelDataProvider.GetDamageForLevel(nextLevel);
            hero.HealthPoints.LevelUp(nextLevel);

            hero.Level++;
        }
    }
}
