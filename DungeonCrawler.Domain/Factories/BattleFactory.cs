using DungeonCrawler.Data;

namespace DungeonCrawler.Domain.Factories
{
    public static class BattleFactory
    {
        public static Battle CreateNewIn(Game game)
        {
            var battleId = game.Battles.Count;

            return new Battle(game, game.Hero, game.Monsters[battleId]);
        }
    }
}
