namespace Patterns.AbstractFactory
{
    public class RoadBikeFactory : AbstractBikeFactory
    {
        public override IBike CreateBike(string name)
        {
            return new RoadBike(name);
        }
    }
}
