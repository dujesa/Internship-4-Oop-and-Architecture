using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data
{
    public class DirectAttack : Move
    {
        public DirectAttack(Character mover) : base(mover)
        {
        }

        public override bool IsDefeating(Move opponentMove)
        {
            return opponentMove is SideAttack;
        }
        public override string ToString()
        {
            return "Direct attack";
        }
    }
}
