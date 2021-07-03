using System.Collections.Generic;

namespace Patterns.Behavioral.State
{
    internal class RoadBikeState : BikeState
    {
        public RoadBikeState(BikeState state) : this(state.Bike, state.GetComponents())
        {
        }

        public RoadBikeState(Bike bike) : this(bike, new List<ComponentType>())
        {
        }

        protected RoadBikeState(Bike bike, List<ComponentType> components)
        {
            _components = components;
            Bike = bike;
            Speed = 100;
            Weight = 5;
        }

        public override void Add(ComponentType type)
        {
            _components.Add(type);
            CheckState();
        }

        public override bool NegotiatePothole()
        {
            throw new System.NotSupportedException("Bike wheel buckled!");
        }

        public override void Remove(ComponentType type)
        {
            _components.Remove(type);
            CheckState();
        }

        /// <summary>
        /// This method decides when to upgrade or downgrade the state
        /// </summary>
        private void CheckState()
        {
            if (_components.Contains(ComponentType.Shocks))
            {
                if (_components.Contains(ComponentType.DiscBrakes))
                {
                    Bike.ChangeStateTo(new MountainBikeState(this));
                }
                else
                {
                    Bike.ChangeStateTo(new HybridBikeState(this));
                }
            }
            else
            {
                // do nothing as we're already a road bike
            }
        }
    }
}
