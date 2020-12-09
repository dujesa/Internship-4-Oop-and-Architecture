using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data
{
    public class CounterAttack : IMove
    {
        public bool IsDefeating(IMove opponentMove)
        {
            return opponentMove is DirectAttack;
        }
    }
}
