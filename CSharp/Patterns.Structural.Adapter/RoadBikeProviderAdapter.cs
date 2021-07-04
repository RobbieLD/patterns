namespace Patterns.Structural.Adapter
{
    public class RoadBikeProviderAdapter : IBikeProvider
    {
        private readonly IRoadBikeProvider _provider;

        public RoadBikeProviderAdapter(IRoadBikeProvider provider)
        {
            _provider = provider;
        }

        public void CreateBike()
        {
            _provider.AssembleBike();
        }

        public void ReloadBike()
        {
            _provider.FixBike();
        }

        public void TransferBike()
        {
            _provider.TransferBikeToCustomer();
        }
    }
}
