using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;

namespace DungeonCrawler.Data.Models
{
    public class Goblin : Monster
    {
        public Goblin() : base()
        { 
            AppearanceChance = (int)MonstersInfo.GoblinAppearanceChance;
            Damage = (int)MonstersInfo.GoblinDamage;
            HealthPoints["max"] = (int)MonstersInfo.GoblinHp;

            FullHeal();
        }
    }
}
