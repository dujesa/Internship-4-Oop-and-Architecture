namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Character
    {
        public int Damage { get; }
        public int HealthPoints { get; set; }

        public void Attack(Character opponent)
        {
            opponent.HealthPoints -= Damage;
        }
    }
}
