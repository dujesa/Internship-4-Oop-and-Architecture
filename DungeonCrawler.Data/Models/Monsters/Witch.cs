using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;

namespace DungeonCrawler.Data.Models.Monsters
{
    public class Witch : Monster
    {
        public Witch()
        {
            XpAward = 5;
            AppearanceChance = (int)MonstersInfo.WitchAppearanceChance;
        }

        /* @ToDo: Separate into new service
         * 
         * public List<IMonster> CreateTwoNewMonsters()
         * {
         *      var newMonsters = new List<IMonster>();
         * }
         *  
         * public void DoJumbus()
         * {
         * }
         */

        public override string ToString()
        {
            return $"Witch\n" +
                $"\t{base.ToString()}\n";
        }
    }
}
