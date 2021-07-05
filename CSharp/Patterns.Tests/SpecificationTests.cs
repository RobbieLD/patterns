using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.Specification;
using Moq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Patterns.Tests
{
    [TestClass]
    public class SpecificationTests
    {
        [TestMethod]
        [TestCategory("Specification")]
        public void BikeShop_GetChildrensBikes_ReturnsCorrectBikes()
        {
            // Arrange
            var data = new List<Bike>
            {
                new Bike(12, 4, BikeType.HybridBike, "Green"),
                new Bike(18, 3, BikeType.MountainBike, "Blue")
            }.AsQueryable();

            var mockBikeSet = new Mock<DbSet<Bike>>();
            mockBikeSet.As<IQueryable<Bike>>().Setup(m => m.Provider).Returns(data.Provider);
            mockBikeSet.As<IQueryable<Bike>>().Setup(m => m.Expression).Returns(data.Expression);
            mockBikeSet.As<IQueryable<Bike>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockBikeSet.As<IQueryable<Bike>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var context = new Mock<BikeShopContext>();
            context.Setup(x => x.Bikes).Returns(mockBikeSet.Object);

            var warehouse = new Warehouse(context.Object);

            var bikeShop = new BikeShop(warehouse);

            // Act 
            var results = bikeShop.GetChildrensBikes();

            // Assert
            Assert.AreEqual(results.Count, 1);
        }
    }
}
