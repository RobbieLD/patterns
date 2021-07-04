using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavioral.Mediator
{
    public class Bidder : Participant
    {
        public Bidder(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            base.Receive(from, message);
        }
    }
}
