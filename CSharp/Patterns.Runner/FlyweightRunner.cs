using System;
using Patterns.Structural.Flyweight;
using Patterns.Common;

namespace Patterns.Runner
{
    public class FlyweightRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** FLYWEIGHT PATTERN ***{Environment.NewLine}");

            string[] colors = { "green", "blue", "red" };

            int numberOfBikesToPaint = 100;

            for(int i = 0; i < numberOfBikesToPaint; i++)
            {
                var bike = new Bike();

                string color = colors[new Random().Next(0, 2)];

                var robot = PaintRobotFactory.GetRobot(color);

                robot.PaintBike(bike);

                Console.WriteLine(string.Format("{0} by robot serial number: {1}", bike.ToString(), robot.GetHashCode()));
            }
        }
    }
}
