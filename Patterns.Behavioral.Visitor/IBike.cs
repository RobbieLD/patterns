using System;
using Patterns.Common;

namespace Patterns.Behavioral.Visitor
{
    public interface IBike
    {
        ConsoleColor Colour { get; set; }
        string Name { get; }
        int TirePressure { get; set; }
        BikeType Type { get; }

        void AcceptRobot(IRobot robotVisitor);
        void Display();
        string ToString();
    }
}