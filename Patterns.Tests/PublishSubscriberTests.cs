using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Patterns.Behavioral.PublishSubscriber;
using System.IO;

namespace Patterns.Tests
{
    [TestClass]
    public class PublishSubscriberTests
    {
        [TestMethod]
        [TestCategory("PublishSubscriber")]
        public void BikeShop_NewBikeEventRaised_SubscriberIsCalled()
        {
            // Arrange
            IBikeShop shop = new BikeShop("Shop");
            BikeCustomer customerOne = new BikeCustomer(shop, "Customer");

            using (StringWriter writer = new StringWriter())
            {
                // Capture the console output
                Console.SetOut(writer);

                // Act
                shop.NewBikeArrived("Rocket");

                // Assert
                Assert.IsTrue(writer.ToString().Contains("Rocket"));

            }
        }
    }
}
