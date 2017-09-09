namespace Patterns.Behavioral.Iterator
{
    public class BikeProductionLine : IBikeProductionLine
    {
        private Bike LastBike { get; set; }
        private Bike FirstBike { get; set; }

        public BikeProductionLine(Bike firstBike)
        {
            FirstBike = firstBike;
            LastBike = firstBike;
        }

        public BikeIterator CreateIterator()
        {
            return new BikeIterator(FirstBike);
        }

        public void Add(Bike bike)
        {
            LastBike.Next = bike;
            LastBike = bike;
        }
    }
}
