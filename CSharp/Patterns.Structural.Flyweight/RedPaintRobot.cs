namespace Patterns.Structural.Flyweight
{
    public class RedPaintRobot : IPaintRobot
    {
        public void PaintBike(Bike bike)
        {
            bike.Paint("red");
        }
    }
}
