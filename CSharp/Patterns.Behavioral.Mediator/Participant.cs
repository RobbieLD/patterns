using System;

namespace Patterns.Behavioral.Mediator
{
    public abstract class Participant
    {
        public IAuction Auction { get; set; }
        public readonly string Name;

        public Participant(string name)
        {
            Name = name;
        }

        public void Participate(string message)
        {
            Auction.Participate(this, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: {message}");
        }
    }
}
