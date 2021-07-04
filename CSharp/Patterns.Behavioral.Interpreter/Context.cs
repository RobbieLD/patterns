namespace Patterns.Behavioral.Interpreter
{
    public class Context
    {
        public readonly Bike UnconvertedBike;
        public Bike ConvertedBike { get; set; }

        public Context(Bike bike)
        {
            UnconvertedBike = bike;
            ConvertedBike = new Bike();
        }
    }
}
