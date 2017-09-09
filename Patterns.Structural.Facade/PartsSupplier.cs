namespace Patterns.Structural.Facade
{
    public class PartsSupplier : IPartsSupplier
    {
        private readonly ITomsPartsSupplier _tom;
        private readonly IDicksBikeBits _dick;
        private readonly IHarrysJunkYard _harry;

        public PartsSupplier(ITomsPartsSupplier tom, IDicksBikeBits dick, IHarrysJunkYard harry)
        {
            _tom = tom;
            _dick = dick;
            _harry = harry;
        }

        public void GetBrakes()
        {
            // We'll get the brakes from Tom
            _tom.GetBrakes();
        }

        public void GetShocks()
        {
            // We get shocks from Harry
            _harry.GetShocks();
        }

        public void GetWheels()
        {
            // We get wheels from Dick. He's the specialist.
            _dick.GetWheels();
        }
    }
}
