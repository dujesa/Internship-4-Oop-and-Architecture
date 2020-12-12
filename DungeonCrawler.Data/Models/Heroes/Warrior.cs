using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data.Models.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            Damage = new Damage(this);
            HealthPoints = new HealthPoints(this);

            FullHeal();
        }

        public void RageAttack(Monster opponent)
        {
            var rageCostInHp = (int)(HealthPoints.Max * 0.15);

            if (HealthPoints.Current < rageCostInHp)
            {
                Attack(opponent);
            }

            HealthPoints.HurtFor(rageCostInHp);

            var rageDamage = Damage.Value * 2;
            opponent.HealthPoints.HurtFor(rageDamage);
        }

        public override string ToString()
        {
            return $"Warrior\n" +
                $"{base.ToString()}";
        }
    }
}
