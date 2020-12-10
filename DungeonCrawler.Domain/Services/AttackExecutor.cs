using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Domain.Services
{
    public static class AttackExecutor
    {
        public static void Execute(Character attacker, Character defender)
        {
            defender.HealthPoints.HurtFor(attacker.Damage.Value);
        }
    }
}
