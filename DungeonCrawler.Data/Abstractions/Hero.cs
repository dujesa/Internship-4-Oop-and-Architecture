using System;

namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Hero : Character
    {
        public string Name { get; set; } = "NoName Hero";
        public int Experience { get; set; } = 0;
        public int Level { get; set; } = 1;

        public void HealUp(int healingPoints)
        {
            var healedHp = HealthPoints.Current + healingPoints;

            HealthPoints.Current = (healedHp <= HealthPoints.Max) ?
                healedHp :
                HealthPoints.Max;
        }

        public Hero(string name) : base()
        {
            Name = name;

            HeroDataStore.Heroes.Add(this);
        }

        public override string ToString()
        {
            return $"\t{Name}\n" +
                $"\tlvl.{Level} [{Experience}/levelUpXP]\n" +
                $"\t{ base.ToString() }\n";
        }
    }
}
