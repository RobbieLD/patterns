using System;

namespace Patterns.Structural.Compisite
{
    public class ProductionBike : AbstractBike
    {
        public ProductionBike(string name) : base(name)
        {
        }

        public override void Add(AbstractBike ab)
        {
            throw new NotSupportedException("Can't add a child to a production bike");
        }

        public override void Remove(AbstractBike ab)
        {
            throw new NotSupportedException("Can't remove a child from a production bike");
        }

        public override void Display(int depth)
        {
            // Construct a string which creates a string of - as long as the depth of this node
            Console.WriteLine(new String('-', depth) + _name);
        }
    }
}
