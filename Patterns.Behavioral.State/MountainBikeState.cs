using System.Collections.Generic;

namespace Patterns.Behavioral.State
{
    internal class MountainBikeState : BikeState
    {
        public MountainBikeState(BikeState state) : this(state.Bike, state.GetComponents())
        {
        }

        public MountainBikeState(Bike bike) : this(bike, new List<ComponentType>())
        {
        }

        protected MountainBikeState(Bike bike, List<ComponentType> components)
        {
            _components = components;
            Bike = bike;
            Speed = 30;
            Weight = 9;
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
                    // nothing to do here
                }
                else
                {
                    Bike.ChangeStateTo(new HybridBikeState(this));
                }
            }
            else
            {
                Bike.ChangeStateTo(new RoadBikeState(this));
            }
        }
    }
}
