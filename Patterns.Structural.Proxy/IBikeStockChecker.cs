namespace Patterns.Structural.Proxy
{
    public interface IBikeStockChecker
    {
        int GetNumberOfMountainBikes(string warehouseName);
        int GetNumberOfRoadBikes(string warehouseName);
    }
}
