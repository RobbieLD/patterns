namespace Patterns.Bridge
{
    public abstract class AbstractRider : IRider
    {
        protected readonly string _name;

        public IBike Bike { protected get; set; }

        public AbstractRider(string name)
        {
            _name = name;
        }


        public abstract void RideBike();
    }
}
