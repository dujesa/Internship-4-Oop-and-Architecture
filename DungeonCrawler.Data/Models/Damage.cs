using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Data.Models.Heroes;
using DungeonCrawler.Data.Models.Monsters;
using System;

namespace DungeonCrawler.Data.Models
{
    public class Damage
    {
        public int Value { get; private set; }

        public Damage(Character character)
        {
            if (character is Warrior)
            {
                Value = (int)HeroesInfo.WarriorInitialDamage;
            }
            else if (character is Mage)
            {
                Value = (int)HeroesInfo.MageInitialDamage;
            }
            else if (character is Ranger)
            {
                Value = (int)HeroesInfo.RangerInitialDamage;
            }
            else if (character is Brute)
            {
                Value = (int)MonstersInfo.BruteDamage;
            }
            else if (character is Goblin)
            {
                Value = (int)MonstersInfo.GoblinDamage;
            }
            else if (character is Witch)
            {
                Value = (int)MonstersInfo.WitchDamage;
            }
            else
            {
                Value = (int)CharactersInfo.InitialHp;
            }
        }

        public void RaiseFor(int raisingValue)
        {
            Value += raisingValue;
        }
    }
}
