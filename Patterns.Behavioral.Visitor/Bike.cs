using System;
using Patterns.Common;

namespace Patterns.Behavioral.Visitor
{
    public abstract class Bike : IBike
    {
        public int TirePressure { get; set; }
        public string Name { get; private set; }
        public ConsoleColor Colour { get; set; }
        public BikeType Type { get; private set; }

        public Bike(string name, BikeType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{Name} now has tires at {TirePressure} and is colourd {Colour}";
        }

        public void AcceptRobot(IRobot robotVisitor)
        {
            robotVisitor.DoWork(this);
        }

        public void Display()
        {
            ConsoleColor defaultColour = Console.ForegroundColor;
            Console.ForegroundColor = Colour;
            Console.WriteLine(ToString());
            Console.ForegroundColor = defaultColour;
        }
    }
}
