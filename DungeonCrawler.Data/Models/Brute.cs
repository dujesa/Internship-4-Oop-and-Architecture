using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using System;

namespace DungeonCrawler.Data.Models
{
    public class Brute : Monster
    {
        public Brute() : base()
        {
            AppearanceChance = (int)MonstersInfo.BruteAppearanceChance;
            Damage = (int)MonstersInfo.BruteDamage;
            HealthPoints["max"] = (int)MonstersInfo.BruteHp;

            FullHeal();
        }

        public bool IsHardAttack()
        {
            Random random = new Random();
            int randomChance = random.Next(0, 100);
            
            //25% chance for hard attack
            return (randomChance < 25);
        }
    }
}
