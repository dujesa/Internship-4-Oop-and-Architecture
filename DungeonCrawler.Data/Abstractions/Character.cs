using DungeonCrawler.Data.Enums;
using System.Collections.Generic;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Character
    {
        public int Damage { get; set; }
        public Dictionary<string, int> HealthPoints { get; set; }

        public Character()
        {
            Damage = (int)CharactersInfo.InitialDamage;
            HealthPoints["max"] = (int)CharactersInfo.InitialHp;

            FullHeal();
        }

        public virtual void Attack(Character opponent)
        {
            opponent.HealthPoints["current"] -= Damage;
        }

        public void FullHeal()
        {
            HealthPoints["curent"] = HealthPoints["max"];
        }
    }
}
