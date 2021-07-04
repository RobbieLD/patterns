namespace Patterns.Behavioral.Iterator
{
    public interface IBikeProductionLine
    {
        void Add(Bike bike);
        BikeIterator CreateIterator();
    }
}