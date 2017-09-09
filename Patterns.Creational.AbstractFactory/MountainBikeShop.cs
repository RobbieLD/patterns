namespace Patterns.Creational.AbstractFactory
{
    public class MountainBikeShop : AbstractBikeShop
    {
        /// <summary>
        /// This constructor is needed so we can do new MountainBikeShop()
        /// with out having the new up a Factory for it to use. It simply
        /// creates a new factory for it's own use.
        /// </summary>
        public MountainBikeShop() : this(new MountainBikeFactory())
        {
        }

        public MountainBikeShop(IBikeFactory factory) : base(factory)
        {
        }

    }
}
