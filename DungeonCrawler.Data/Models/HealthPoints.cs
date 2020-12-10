using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Data.Models.Heroes;
using DungeonCrawler.Data.Models.Monsters;
using System;

namespace DungeonCrawler.Data.Models
{
    public class HealthPoints
    {
        public int Max { get; }
        public int Current { get; protected set; }

        public HealthPoints(Character character)
        {
            if (character is Warrior)
            {
                Max = (int)HeroesInfo.WarriorInitialHp;
            }
            else if (character is Mage)
            {
                Max = (int)HeroesInfo.MageInitialHp;
            }
            else if (character is Ranger)
            {
                Max = (int)HeroesInfo.RangerInitialHp;
            }
            else if (character is Brute)
            {
                Max = (int)MonstersInfo.BruteHp;
            }
            else if (character is Goblin)
            {
                Max = (int)MonstersInfo.GoblinHp;
            }
            else if (character is Witch)
            {
                Max = (int)MonstersInfo.WitchHp;
            }
            else
            {
                Max = (int)CharactersInfo.InitialHp;
            }
        }

        public void HurtFor(int damagePoints)
        {
            damagePoints = (damagePoints <= Current) ? damagePoints : Current;
            Current -= damagePoints;
        }

        public void HealFor(int healPoints)
        {
            var newHp = Current + healPoints;
            Current = (newHp <= Max) ? newHp : Max;
        }

        public void FullHeal() 
        {
            Current = Max;
        }

        public void LevelUp(int nextLevel)
        {
            throw new NotImplementedException();
        }
    }
}
