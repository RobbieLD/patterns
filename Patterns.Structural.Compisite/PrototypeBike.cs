using System;
using System.Collections.Generic;

namespace Patterns.Structural.Compisite
{
    public class PrototypeBike : AbstractBike
    {
        private List<AbstractBike> _children;

        public PrototypeBike(string name) : base(name)
        {
            _children = new List<AbstractBike>();
        }

        public override void Add(AbstractBike ab)
        {
            _children.Add(ab);
        }

        public override void Remove(AbstractBike ab)
        {
            _children.Remove(ab);
        }

        public override void Display(int depth = 1)
        {
            Console.WriteLine(new String('-', depth) + _name);

            foreach (AbstractBike b in _children)
            {
                b.Display(depth + ADDITIONAL_DEPTH_FOR_CHILDREN);
            }
        }
    }
}
