using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data
{
    public class Round
    {
        public bool IsStunRound { get; }
        public Move HeroMove { get; set; }
        public Move MonsterMove { get; set; }

        public Round(Battle battle)
        {
            battle.Rounds.Add(this);
            IsStunRound = battle.IsStunActivated;
        }
    }
}
