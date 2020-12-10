using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data
{
    public class SideAttack : Move
    {
        public SideAttack(Character mover) : base(mover)
        { 
        }

        public override bool IsDefeating(Move opponentMove)
        {
            return opponentMove is CounterAttack;
        }
        public override string ToString()
        {
            return "Side attack";
        }
    }
}
