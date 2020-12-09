using DungeonCrawler.Data.Enums;
using DungeonCrawler.Data.Models;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Character
    {
        public int Damage { get; set; }
        public HealthPoints HealthPoints { get; protected set; } = new HealthPoints();

        public Character()
        {
            Damage = (int)CharactersInfo.InitialDamage;

            FullHeal();
        }

        public virtual void Attack(Character opponent)
        {
            opponent.HealthPoints.Current -= Damage;
        }

        public void FullHeal()
        {
            HealthPoints.Current = HealthPoints.Max;
        }

        public override string ToString()
        {
            return $"HP: {HealthPoints.Current}";
        }
    }
}
