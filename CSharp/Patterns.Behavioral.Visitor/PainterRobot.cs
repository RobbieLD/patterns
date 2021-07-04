using System;

namespace Patterns.Behavioral.Visitor
{
    public class PainterRobot : IRobot
    {
        private Random random = new Random();
        
        public void DoWork(IBike bike)
        {
            Array values = Enum.GetValues(typeof(ConsoleColor));
            bike.Colour = (ConsoleColor)values.GetValue(random.Next(values.Length));
        }
    }
}
