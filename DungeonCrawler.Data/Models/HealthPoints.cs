using DungeonCrawler.Data.Enums;
using System;

namespace DungeonCrawler.Data.Models
{
    public class HealthPoints
    {
        public int Max { get; }
        public int Current { get; protected set; }

        public HealthPoints()
        { 
            Max = (int)CharactersInfo.InitialHp;
        }

        public HealthPoints(int max)
        {
            Max = max;
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
