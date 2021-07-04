
using System.Collections.Generic;

namespace Patterns.Structural.Flyweight
{
    public class PaintRobotFactory
    {
        // This dictionary will store the paint robots, one for each color.
        // That way when they are needed we can simply use an existing one 
        // of the correct color and now create a whole new one.
        private static readonly Dictionary<string, IPaintRobot> Robots = new();
        
        public static IPaintRobot GetRobot(string color)
        {
            if (!Robots.ContainsKey(color))
            {
                switch (color)
                {
                    case "green":
                        Robots.Add(color, new GreenPaintRobot());
                        break;
                    case "blue":
                        Robots.Add(color, new BluePaintRobot());
                        break;
                    case "red":
                        Robots.Add(color, new RedPaintRobot());
                        break;
                    default:
                        throw new System.NotSupportedException(string.Format("There is no robot which can paint {0}", color));
                }
            }

            return Robots[color];
        }
    }
}
