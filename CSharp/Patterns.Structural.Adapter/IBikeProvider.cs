namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// The common interface which all my bike shop code will rely on instead of on the
    /// actualy implimentations of the bike providers
    /// </summary>
    public interface IBikeProvider
    {
        void CreateBike();
        void ReloadBike();
        void TransferBike();
    }
}
