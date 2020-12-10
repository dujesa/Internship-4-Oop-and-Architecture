using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using System;

namespace DungeonCrawler.Data.Models.Monsters
{
    public class Brute : Monster
    {
        public Brute() : base()
        {
            AppearanceChance = (int)MonstersInfo.BruteAppearanceChance;
            Damage = (int)MonstersInfo.BruteDamage;
            HealthPoints = new HealthPoints((int)MonstersInfo.BruteHp);

            FullHeal();
        }

        public override void Attack(Character opponent)
        {
            var attackDamage = Damage;

            if (IsHardAttack())
            {
                attackDamage = (int)(opponent.HealthPoints.Current * 0.5);
            }

            opponent.HealthPoints.HurtFor(attackDamage);
        }

        private bool IsHardAttack()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            return randomNumber < (int)MonstersInfo.BruteHardAttackChance;
        }
        public override string ToString()
        {
            return $"Brute\n" +
                $"\t{base.ToString()}\n";
        }
    }
}
