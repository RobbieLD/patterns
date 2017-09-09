using System.Collections.Generic;

namespace Patterns.State
{
    public abstract class BikeState
    {
        protected List<ComponentType> _components = new List<ComponentType>();

        public int Speed { get; set; }
        public int Weight { get; set; }
        public Bike Bike { get; set; }

        public abstract void Add(ComponentType type);
        public abstract void Remove(ComponentType type);

        public List<ComponentType> GetComponents()
        {
            return _components;
        }

        public override string ToString()
        {
            return string.Format("Speed:{0}, Weight:{1}", Speed, Weight);
        }
    }
}
