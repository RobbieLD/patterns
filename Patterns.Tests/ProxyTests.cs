using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Structural.Proxy;

namespace Patterns.Tests
{
    [TestClass]
    public class ProxyTests
    {
        [TestMethod]
        [TestCategory("Proxy")]
        public void BikeStockCheckerProxy_GetMethods_CallProxyMethodsAndReturnInt()
        {
            // Arrange
            IBikeStockChecker proxy = new BikeStockCheckerProxy();

            // Act
            int numberOfMountainBikes = proxy.GetNumberOfMountainBikes("BigWarehouse");
            int numberOfRoadBikes = proxy.GetNumberOfRoadBikes("GiantWarehouse");

            // Assert
            Assert.IsTrue(numberOfMountainBikes < numberOfRoadBikes);
        }
    }
}
