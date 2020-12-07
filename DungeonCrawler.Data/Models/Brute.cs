using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data.Models
{
    public class Brute : Monster
    {
        private bool IsHardAttack()
        {
            return false;
        }
    }
}
