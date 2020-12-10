using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;

namespace DungeonCrawler.Data.Models.Monsters
{
    public class Goblin : Monster
    {
        public Goblin() : base()
        {
            XpAward = 1;
            AppearanceChance = (int)MonstersInfo.GoblinAppearanceChance;
            Damage = new Damage(this);
            HealthPoints = new HealthPoints(this);

            FullHeal();
        }

        public override string ToString()
        {
            return $"Goblin\n" +
                $"\t{base.ToString()}";
        }
    }
}
