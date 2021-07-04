namespace Patterns.Behavioral.Iterator
{
    public class BikeIterator : IBikeIterator
    {
        public BikeIterator(Bike firstBike)
        {
            CurrentBike = firstBike;
        }

        public bool IsFinished
        {
            get
            {
                return CurrentBike == null;
            }
        }

        public Bike CurrentBike { get; set; }

        public Bike Next()
        {
            return CurrentBike = CurrentBike.Next;
        }
    }
}
