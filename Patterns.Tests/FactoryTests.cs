using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Factory;
using Patterns.Common;

namespace Patterns.Tests
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        [TestCategory("Factory")]
        public void BikeFactory_CreateBike_ReturnsInstanceOfIBike()
        {
            // Arrange
            // Act
            // Assert
            Assert.IsInstanceOfType(BikeFactory.CreateBike(BikeType.Hybrid), typeof(IBike));
        }
    }
}
