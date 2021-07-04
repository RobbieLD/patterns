namespace Patterns.Structural.Flyweight
{
    public class BluePaintRobot : IPaintRobot
    {
        public void PaintBike(Bike bike)
        {
            bike.Paint("blue");
        }
    }
}
