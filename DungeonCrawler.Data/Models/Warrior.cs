using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;

namespace DungeonCrawler.Data.Models
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            Damage = (int)HeroesInfo.WarriorInitialDamage;
            HealthPoints["max"] = (int)HeroesInfo.WarriorInitialHp;

            FullHeal();
        }

        public void RageAttack(Monster opponent)
        {
            var rageCostInHp = (int)(HealthPoints["max"] * 0.15);
            //provjeri koliko je rageCost!!!
            
            if (HealthPoints["current"] < rageCostInHp)
            {
                Attack(opponent);
            }

            HealthPoints["current"] -= rageCostInHp;

            var rageDamage = Damage * 2;
            opponent.HealthPoints["current"] -= rageDamage;
        }

        public override string ToString()
        {
            return $"Warrior\n" +
                $"{base.ToString()}";
        }
    }
}
