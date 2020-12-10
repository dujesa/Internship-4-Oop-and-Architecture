namespace DungeonCrawler.Data.Models
{
    public class Experience
    {
        public int Current { get; private set; } = 0;
        public int ForLevelUp { get; private set; } = 5;

        private int _level = 1; 

        public bool RaiseFor(int gainedXp)
        {
            var didLevelUp = false;
            Current += gainedXp;

            if (Current >= ForLevelUp)
            {
                Current -= ForLevelUp;
                ForLevelUp += _level;
                _level++;

                didLevelUp = true;
            }

            return didLevelUp;
        }

        public override string ToString()
        {
            return $"{Current}/{ForLevelUp}";
        }
    }
}
