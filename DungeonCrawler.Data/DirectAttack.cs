using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data
{
    public class DirectAttack : IMove
    {
        public bool IsDefeating(IMove opponentMove)
        {
            return opponentMove is SideAttack;
        }
    }
}
