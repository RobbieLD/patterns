namespace Patterns.Behavioral.Specification
{
    public class Bike
    {
        public int Id { get; set; }
        public int WheelSize { get; set; }
        public int Gears { get; set; }
        public BikeType BikeType { get; set; }
        public string Color { get; set; }

        public Bike(int wheelSize, int gears, BikeType bikeType, string color)
        {
            WheelSize = wheelSize;
            Gears = gears;
            BikeType = bikeType;
            Color = color;
        }

        public override string ToString()
        {
            return string.Format("{0} -> Wheel Size: {1}, Gears: {2}, Color: {3}", BikeType, WheelSize, Gears, Color);
        }
    }
}
