using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data
{
    public class SideAttack : IMove
    {
        public bool IsDefeating(IMove opponentMove)
        {
            return opponentMove is CounterAttack;
        }
    }
}
