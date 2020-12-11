using DungeonCrawler.Data.Models;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Character
    {
        public Damage Damage { get; protected set; }
        public HealthPoints HealthPoints { get; protected set; }

        public Character()
        {
            Damage= new Damage(this);
            HealthPoints = new HealthPoints(this);

            FullHeal();
        }

        public virtual void Attack(Character opponent)
        {
            opponent.HealthPoints.HurtFor(Damage.Value);
        }

        public void FullHeal()
        {
            HealthPoints.FullHeal();
        }

        public bool IsDead()
        {
            return HealthPoints.Current == 0;
        }

        public override string ToString()
        {
            return $"HP: {HealthPoints.Current}/{HealthPoints.Max}";
        }
    }
}
