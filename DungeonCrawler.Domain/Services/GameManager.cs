using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using DungeonCrawler.Domain.Factories;

namespace DungeonCrawler.Domain.Services
{
    public static class GameManager
    {
        public static Game InitializeNewGame(Hero hero)
        {
            Game game = new Game(hero);

            for (int i = 0; i < 10; i++)
            {
                game.Monsters.Add(MonsterFactory.CreateRandom());
            }

            return game;
        }
    }
}
