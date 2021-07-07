using System;
using System.Collections.Generic;
using Patterns.Structural.Marker;

namespace Patterns.Runner
{
    public class MarkerRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            var firstGroup = new List<Bike>
            {
                new Cannondale(),
                new Specialized(),
                new Giant(),
                new Trek()
            };

            var interfaceMarshal = new InterfaceRaceMarshal(firstGroup);

            Console.WriteLine("Before The Race");
            Console.WriteLine(interfaceMarshal.ToString());
            interfaceMarshal.StartRace();
            Console.WriteLine("During The Race");
            Console.WriteLine(interfaceMarshal.ToString());

            var secondGroup = new List<Bike>
            {
                new Cannondale(),
                new Specialized(),
                new Giant(),
                new Trek()
            };

            var attributeMarshal = new AttributeRaceMarshal(secondGroup);

            Console.WriteLine("Before The Race");
            Console.WriteLine(attributeMarshal.ToString());
            attributeMarshal.StartRace();
            Console.WriteLine("During The Race");
            Console.WriteLine(attributeMarshal.ToString());

        }
    }
}
