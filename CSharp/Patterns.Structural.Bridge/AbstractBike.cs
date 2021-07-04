namespace Patterns.Structural.Bridge
{
    public abstract class AbstractBike : IBike
    {
        protected readonly string _bikeType;

        public AbstractBike(string type)
        {
            _bikeType = type;
        }

        public abstract void Ride();
    }
}
