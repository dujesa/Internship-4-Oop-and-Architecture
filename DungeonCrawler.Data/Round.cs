using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data
{
    public class Round
    {
        public bool IsStunRound { get; }
        public IMove HeroMove { get; set; }
        public IMove MonsterMove { get; set; }

        public Round(Battle battle, bool isStunRound)
        {
            battle.Rounds.Add(this);
            IsStunRound = isStunRound;
        }
    }
}
