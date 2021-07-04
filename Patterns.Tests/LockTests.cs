using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Concurrency.Lock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.Tests
{
    [TestClass]
    public class LockTests
    {
        [TestMethod]
        [TestCategory("Lock")]
        public void BikeWarehouse_OrderBike_DoesntGoBelowZero()
        {
            // Arrange
            var warehouse = new Warehouse(10);
            var bikeShop = new BikeShop(warehouse);

            // Act
            bikeShop.SellBike();

            // Assert
            Assert.AreEqual(warehouse.CheckStock(), 9);
        }
    }
}
