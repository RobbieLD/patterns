using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Command
{
    class Bike : IBike
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        private Tuple<int, int> _origin;

        public Bike(int xOrigin, int yOrigin)
        {
            _origin = new Tuple<int, int>(xOrigin, yOrigin);
        }

        public double GetDistanceFromOrigin()
        {
            // use pythagoras
            return Math.Sqrt(Math.Pow((Math.Abs(XPosition - _origin.Item1)), 2) + Math.Pow((Math.Abs(YPosition - _origin.Item2)), 2));
        }

        public override string ToString()
        {
            return $"({XPosition}, {YPosition})";
        }

    }
}
