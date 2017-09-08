namespace Patterns.Compisite
{
    public abstract class AbstractBike
    {
        protected const int ADDITIONAL_DEPTH_FOR_CHILDREN = 2;
        protected string _name;

        public AbstractBike(string name)
        {
            _name = name;
        }

        public abstract void Add(AbstractBike ab);
        public abstract void Remove(AbstractBike ab);
        public abstract void Display(int depth);
    }
}
