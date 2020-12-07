using DungeonCrawler.Data.Abstractions;

namespace DungeonCrawler.Data.Models
{
    public class Mage : Hero 
    {
        private bool _isResurrected = false;

        public void Mana()
        { }

        public void Resurrect()
        {
            if (_isResurrected)
            {
                return;
            }

            //HealthPoints = HealthPoints.max
            _isResurrected = true;
        }
    }
}
