using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.Command
{
    public class BikeRider
    {
        private Bike _bike;
        private Stack<BikeCommand> _commands = new Stack<BikeCommand>();

        public BikeRider(int x, int y)
        {
            _bike = new Bike(x, y);

            Console.WriteLine(ToString());
        }

        public BikeRider() : this(0,0)
        { }

        public void Ride(BikeAction action)
        {
            Console.WriteLine($"Bike is now doing action: {action}");

            BikeCommand command = new BikeCommand(_bike, action);
            _commands.Push(command);

            command.DoAction();

            Console.WriteLine(ToString());
        }

        public void UnRide(int numberOfActions)
        {
            for(int i = 0; i < numberOfActions; i++)
            {
                BikeCommand command = _commands.Pop();
                command.UndoAction();
                Console.WriteLine($"Bike is undoing action: {command}");
                Console.WriteLine(ToString());
            }
        }

        public override string ToString()
        {
            return $" - Bikes current postion is {_bike} and {_bike.GetDistanceFromOrigin()} from origin";
        }
    }
}
