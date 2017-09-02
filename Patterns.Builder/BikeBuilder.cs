namespace Patterns.Builder
{
    public abstract class BikeBuilder
    {
        public Bike Bike { get; protected set; }

        public abstract void AddFrame();
        public abstract void AddWheels();
        public abstract void AddBrakes();
    }
}
