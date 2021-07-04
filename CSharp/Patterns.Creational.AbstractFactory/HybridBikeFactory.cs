namespace Patterns.Creational.AbstractFactory
{
    public class HybridBikeFactory : AbstractBikeFactory
    {
        public override IBike CreateBike(string name)
        {
            return new HybridBike(name);
        }
    }
}
