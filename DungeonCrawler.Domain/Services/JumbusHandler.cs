using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using System;

namespace DungeonCrawler.Domain.Services
{
    public static class JumbusHandler
    {
        public static void Handle(Game game)
        {
            RandomiseHealthPoints(game.Hero);

            foreach (var monster in game.Monsters)
            {
                RandomiseHealthPoints(monster);
            }

            game.DeactivateJumbus();
        }

        private static void RandomiseHealthPoints(Character character)
        {
            Random random = new Random();

            character.FullHeal();
            character.HealthPoints.HurtFor(random.Next(character.HealthPoints.Max));
        }
    }
}
