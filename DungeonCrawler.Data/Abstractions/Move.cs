namespace DungeonCrawler.Data.Abstractions
{
    public abstract class Move
    {
        public Character Mover { get; set; }
        public abstract bool IsDefeating(Move opponentMove);

        public Move(Character mover)
        {
            Mover = mover;
        }
    }
}
