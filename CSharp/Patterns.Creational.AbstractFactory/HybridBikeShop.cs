namespace Patterns.Creational.AbstractFactory
{
    public class HybridBikeShop : AbstractBikeShop
    {
        public HybridBikeShop(IBikeFactory factory) : base(factory)
        {
        }

        public HybridBikeShop() : this(new HybridBikeFactory())
        {
        }
    }
}
