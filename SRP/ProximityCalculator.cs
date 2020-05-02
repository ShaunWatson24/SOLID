namespace SRP
{
    public class ProximityCalculator
    {
        public ProximityCalculator()
        {
        }

        public ProximityCalculator(Battle battle)
        {
            this.Battle = battle;
        }

        public bool IsInRange(Character source, Character target)
        {
            //Perform Calculations to Determine Target Proximity
            //int playerPosition = source.Position;
            //int targetPosition = target.Position;...
            return true;
        }

        protected Battle Battle { get; private set; }
    }
}