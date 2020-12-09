namespace DungeonCrawler.Data.Abstractions
{
    public interface IMove
    {
        bool IsDefeating(IMove opponentMove);
    }
}
