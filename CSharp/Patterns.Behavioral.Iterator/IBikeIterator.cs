namespace Patterns.Behavioral.Iterator
{
    public interface IBikeIterator
    {
        Bike Next();
        bool IsFinished { get; }
        Bike CurrentBike { get; set; }
    }
}
