namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// This is the mountain bike provider adapter that will convert
    /// their methods into ours
    /// </summary>
    public class MountainBikeProviderAdapter : IBikeProvider
    {
        private readonly IMountainBikeProvider _provider;

        public MountainBikeProviderAdapter(IMountainBikeProvider provider)
        {
            _provider = provider;
        }

        public void CreateBike()
        {
            _provider.BuildBike();
        }

        public void ReloadBike()
        {
            _provider.RepairBike();
        }

        public void TransferBike()
        {
            _provider.SellBike();
        }
    }
}
