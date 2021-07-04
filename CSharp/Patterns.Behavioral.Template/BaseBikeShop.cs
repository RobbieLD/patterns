using System;

namespace Patterns.Behavioral.Template
{
    public abstract class BaseBikeShop
    {
        public void BuildBike()
        {
            IntroduceBike();

            // 1. Asemble Frame, this is the same for all bikes
            AssembleFrame();

            // 2. Add Shocks, this varies from bike to bike
            AddShocks();

            // 3. Add brakes, this varies from bike to bike
            AddBrakes();

            // 4. Add wheels, This is the same for all bikes
            AddWheels();
        }

        // Methods which vary depending on the type of bike, thus these must be overridden in the child classes of the bike shop

        protected abstract void AddShocks();
        protected abstract void AddBrakes();

        // These methods have shared functionality
        protected virtual void IntroduceBike()
        {
            // We need to say something about the bike to start with
            // unless one of the child shops overrides this
            Console.WriteLine($"Building a generic bike");
        }

        // Methods which are the same for all bikes
        internal void AddWheels()
        {
            Console.WriteLine($" - Adding Wheels");
        }

        internal void AssembleFrame()
        {
            Console.WriteLine($" - Assembling Frame");
        }

    }
}
