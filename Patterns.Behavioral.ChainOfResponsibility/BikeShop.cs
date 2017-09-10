using Patterns.Common;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    public abstract class BikeShop
    {
        public BikeShop Successor { get; set; }
        public readonly string Name;

        public BikeShop(string name)
        {
            Name = name;
        }

        public abstract void FillOrder(BikeType type);
    }
}
