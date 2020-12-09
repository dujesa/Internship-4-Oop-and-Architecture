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

        public static void ExecuteGame(Game game)
        {
            var battleCounter = 0;

            while (game.Status != GameStatus.HeroWon && game.Status != GameStatus.HeroLost && battleCounter < 10)
            {
                Battle battle = new Battle(game, game.Hero, game.Monsters[battleCounter]);

                //@toDo: battle logic
                /*var battleWinner = battleManager.ExecuteBattle(battle);

                if (battleWinner is Monster)
                {
                    game.Status = GameStatus.HeroLost;
                }

                if (battleWinner is Hero)
                {
                    game.Status = GameStatus.HeroWon;
                }

                battleCounter++;*/
            }
        }
    }
}
