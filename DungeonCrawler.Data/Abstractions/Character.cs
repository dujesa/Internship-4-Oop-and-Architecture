using DungeonCrawler.Data.Enums;
using System.Collections.Generic;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Character
    {
        public int Damage { get; set; }
        public Dictionary<string, int> HealthPoints { get; } = new Dictionary<string, int>();

        public Character()
        {
            Damage = (int)CharactersInfo.InitialDamage;
            HealthPoints["max"] = (int)CharactersInfo.InitialHp;
            HealthPoints["current"] = 0;


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

        public override string ToString()
        {
            return $"HP: {HealthPoints["current"]}";
        }
    }
}
