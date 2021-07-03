using System;

namespace Patterns.Behavioral.State
{
    public class Bike
    {
        private BikeState State { get; set; }

        private string _name;


        public Bike(string name)
        {
            _name = name;
            // Give the bike it's default state of road bike
            State = new RoadBikeState(this);
        }

        public bool AttemptToNegotiatePothole()
        {
            return this.State.NegotiatePothole();
        }

        public void ChangeStateTo(BikeState state)
        {
            this.State = state;
        }

        public void Display()
        {
            Console.WriteLine("{0} is riding a {1} with {2}", _name, State.GetType().Name, State.ToString());
        }

        public void Add(ComponentType type)
        {
            State.Add(type);
        }

        public void Remove(ComponentType type)
        {
            State.Remove(type);
        }
    }
}
