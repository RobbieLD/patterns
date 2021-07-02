using System.Collections.Generic;

namespace Patterns.Behavioral.State
{
    internal class HybridBikeState : BikeState
    {
        public HybridBikeState(BikeState state) : this(state.Bike, state.GetComponents())
        {
        }

        public HybridBikeState(Bike bike) : this(bike, new List<ComponentType>())
        {
        }

        protected HybridBikeState(Bike bike, List<ComponentType> components)
        {
            _components = components;
            Bike = bike;
            Speed = 50;
            Weight = 7;
        }

        public override void Add(ComponentType type)
        {
            _components.Add(type);
            CheckState();
        }

        public override bool NegotiatePothole()
        {
            return true;
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
            // This logic probably could be improved
            if (_components.Contains(ComponentType.Shocks))
            {
                if (_components.Contains(ComponentType.DiscBrakes))
                {
                    Bike.ChangeStateTo(new MountainBikeState(this));
                }
                else
                {
                    // nothing to do here
                }
            }
            else
            {
                Bike.ChangeStateTo(new RoadBikeState(this));
            }
        }
    }
}
