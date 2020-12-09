using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using System;

namespace DungeonCrawler.Data.Models.Heroes
{
    public class Ranger : Hero
    {
        public int CriticalHitChance { get; } = (int)HeroesInfo.RangerInitialCriticalHitChance;
        public int StunChance { get; } = (int)HeroesInfo.RangerInitialStunChance;
        public Ranger(string name) : base(name)
        {
        }

        public override void Attack(Character opponent)
        {
            var attackDamage = Damage;

            if (IsCriticalHit())
            {
                attackDamage *= 2;
            }

            opponent.HealthPoints.Current -= attackDamage;
        }

        public bool IsStunning()
        {
            Random random = new Random();
            var randomNumber = random.Next(0, 100);

            return randomNumber < StunChance;
        }

        private bool IsCriticalHit()
        {
            Random random = new Random();
            var randomNumber = random.Next(0, 100);

            return randomNumber < CriticalHitChance;
        }

        public override string ToString()
        {
            return $"Ranger\n" +
                $"{base.ToString()}";
        }
    }
}
