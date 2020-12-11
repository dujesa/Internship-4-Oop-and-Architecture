using DungeonCrawler.Data.Models;
using System;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Hero : Character
    {
        public string Name { get; set; } = "NoName Hero";
        public Experience Experience { get; private set; } = new Experience();
        public int Wins { get; set; } = 0;
        public int Level { get; set; } = 1;

        public void HealUp(int healingPoints)
        {
            HealthPoints.HealFor(healingPoints);
        }

        public void AwardForBattleWin()
        {
            Wins++;
            HealthPoints.HealFor((int)(HealthPoints.Max * 0.25));
        }

        public void ExperienceUp(int awardXp)
        {
            var didLevelUp = Experience.RaiseFor(awardXp);

            if (didLevelUp)
            {
                Damage.RaiseFor(Level);
                HealthPoints.RaiseMaxFor(Level*10);
                Level++;
            }
        }

        public Hero(string name) : base()
        {
            Name = name;

            HeroDataStore.Heroes.Add(this);
        }

        public override string ToString()
        {
            return $"\t{Name}\n" +
                $"\tlvl.{Level} [{Experience.Current}/{Experience.ForLevelUp}]\n" +
                $"\t{ base.ToString() }\n";
        }
    }
}
