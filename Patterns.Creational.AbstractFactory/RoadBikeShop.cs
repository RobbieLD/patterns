namespace Patterns.Creational.AbstractFactory
{
    public class RoadBikeShop : AbstractBikeShop
    {
        public RoadBikeShop(IBikeFactory factory) : base(factory)
        {
        }

        public RoadBikeShop() : this(new RoadBikeFactory())
        {
        }
    }
}
