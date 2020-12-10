using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data
{
    public class CounterAttack : Move
    {
        public CounterAttack(Character mover) : base(mover)
        {
        }

        public override bool IsDefeating(Move opponentMove)
        {
            return opponentMove is DirectAttack;
        }

        public override string ToString()
        {
            return "Counter attack";
        }
    }
}
