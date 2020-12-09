using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using System;

namespace DungeonCrawler.Data.Models
{
    public class Mage : Hero
    {
        private bool _isResurrected = false;

        public int Mana { get; private set; } = (int)HeroesInfo.MageInitialMana;

        public Mage(string name) : base(name)
        {
            Damage = (int)HeroesInfo.MageInitialDamage;
            HealthPoints["max"] = (int)HeroesInfo.MageInitialHp;

            FullHeal();
        }

        public void UseMana()
        {
            if (Mana <= 0)
            {
                return;
            }

            Random random = new Random();
            var manaHealingPoints = random.Next(1, Mana + 1);

            Mana -= manaHealingPoints;

            HealUp(manaHealingPoints);
        }

        public void UseFullMana()
        {
            if (Mana <= 0)
            {
                return;
            }

            HealUp(Mana);

            Mana = 0;
        }

        public bool Resurrect()
        {
            if (_isResurrected)
            {
                return false;
            }

            FullHeal();
            _isResurrected = true;

            return true;
        }

        public override string ToString()
        {
            return $"Mage\n" +
                $"{base.ToString()}";
        }
    }
}
