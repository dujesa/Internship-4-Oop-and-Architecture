﻿using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;

namespace DungeonCrawler.Data.Models.Monsters
{
    public class Goblin : Monster
    {
        public Goblin() : base()
        {
            AppearanceChance = (int)MonstersInfo.GoblinAppearanceChance;
            Damage = (int)MonstersInfo.GoblinDamage;
            HealthPoints = new HealthPoints((int)MonstersInfo.GoblinHp);

            FullHeal();
        }

        public override string ToString()
        {
            return $"Goblin\n" +
                $"\t{base.ToString()}";
        }
    }
}