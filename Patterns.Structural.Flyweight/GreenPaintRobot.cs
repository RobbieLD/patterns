namespace Patterns.Structural.Flyweight
{
    public class GreenPaintRobot : IPaintRobot
    {
        public void PaintBike(Bike bike)
        {
            bike.Paint("green");
        }
    }
}
