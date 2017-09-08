namespace Patterns.Proxy
{
    public class BikeStockCheckerProxy : IBikeStockChecker
    {
        private BikeStockChecker _checker = new BikeStockChecker();

        public int GetNumberOfMountainBikes(string warehouseName)
        {
            return _checker.GetNumberOfMountainBikes(warehouseName);
        }

        public int GetNumberOfRoadBikes(string warehouseName)
        {
            return _checker.GetNumberOfRoadBikes(warehouseName);
        }
    }
}
