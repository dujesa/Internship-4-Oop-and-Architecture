using DungeonCrawler.Data;

namespace DungeonCrawler.Domain.Services
{
    public static class BattleManager
    {
        public static void ProvideWinner(Battle battle)
        {
            if (battle.Hero.IsDead())
            {
                battle.Winner = battle.Monster;
                
                return;
            }

            battle.Winner = battle.Hero;
        }
    }
}
