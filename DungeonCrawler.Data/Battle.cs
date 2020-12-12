using DungeonCrawler.Data.Abstractions;
using System.Collections.Generic;

namespace DungeonCrawler.Data
{
    public class Battle
    {
        public int Id { get; private set; }
        public Hero Hero { get; set; }
        public Monster Monster { get; set; }
        public Character Winner { get; set; }
        public List<Round> Rounds { get; } = new List<Round>();
        public bool IsStunActivated { get; private set; }

        public Battle(Game game)
        {
            game.AddBattle(this);

            Hero = game.Hero;
            Monster = game.Monsters[Id];
        }

        public void SetId(int newBattleId)
        {
            Id = newBattleId;
        }

        public void ActivateStun()
        {
            IsStunActivated = true;
        }

        public void DeactivateStun()
        {
            IsStunActivated = false;
        }

        public bool HasWinner()
        {
            return Hero.IsDead() || Monster.IsDead();
        }

        public override string ToString()
        {
            return $"\n" +
                $"------{Id + 1}. BATTLE-------\n" +
                $"{Hero}\n" +
                $"-----------VS-----------\n" +
                $"{Monster}\n" +
                $"-----------------------\n";
        }
    }
}
