using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Domain.Services
{
    public static class MoveHandler
    {
        public static Character Handle(Move heroMove, Move monsterMove)
        {
            if (heroMove.IsDefeating(monsterMove))
            {
                return heroMove.Mover;
            }

            if (monsterMove.IsDefeating(heroMove))
            {
                return monsterMove.Mover;
            }

            return null;
        }
    }
}
