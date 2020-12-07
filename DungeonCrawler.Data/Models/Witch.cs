using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data.Models
{
    public class Witch : Monster
    {
        public Witch()
        {
            //AppearingChance = AppearingChanceTypes.Witch;
        }


        /* ToDo: Separate into new service
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
    }
}
