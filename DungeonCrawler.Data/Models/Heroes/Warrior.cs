using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;

namespace DungeonCrawler.Data.Models.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            Damage = (int)HeroesInfo.WarriorInitialDamage;
            HealthPoints = new HealthPoints((int)HeroesInfo.WarriorInitialHp);

            FullHeal();
        }

        public void RageAttack(Monster opponent)
        {
            var rageCostInHp = (int)(HealthPoints.Max * 0.15);
            //provjeri koliko je rageCost!!!

            if (HealthPoints.Current < rageCostInHp)
            {
                Attack(opponent);
            }

            HealthPoints.Current -= rageCostInHp;

            var rageDamage = Damage * 2;
            opponent.HealthPoints.Current -= rageDamage;
        }

        public override string ToString()
        {
            return $"Warrior\n" +
                $"{base.ToString()}";
        }
    }
}
