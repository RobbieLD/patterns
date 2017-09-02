namespace Patterns.AbstractFactory
{
    public class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBike CreateBike(string name)
        {
            return new MountainBike(name);
        }
    }
}
