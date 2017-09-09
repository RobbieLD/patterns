namespace Patterns.Creational.AbstractFactory
{
    public abstract class AbstractBikeShop : IBikeShop
    {
        private readonly IBikeFactory _bikeFactory;

        protected AbstractBikeShop(IBikeFactory factory)
        {
            _bikeFactory = factory;
        }

        public IBike OrderBike(string name)
        {
            return _bikeFactory.CreateBike(name);
        }
    }
}
