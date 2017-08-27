namespace Patterns.Decorator
{
    public abstract class Decorator : Bike
    {
        /**
         * It's important that this is pretected to
         * hide it from other other classes which decorate this class
         */
        protected Bike _bike;

        public Decorator(Bike bike)
        {
            this._bike = bike;
        }

        // Add the methods here you want the decorator to handle
        public override void Display()
        {
            _bike.Display();
        }
    }
}
