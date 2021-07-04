using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Patterns.Behavioral.Observer;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class ObserverTests
    {
        [TestMethod]
        [TestCategory("Observer")]
        public void BikeManufacturer_NotifyShops_NotifiesObservers()
        {
            // Arrange            
            IBikeManufacturer manufacturer = new BikeManufacturer();
            Mock<IBikeShop> mockShop = new Mock<IBikeShop>();
            
            WeakReference<IBikeShop> mShopRef = manufacturer.RegisterShop(mockShop.Object);

            // Act
            manufacturer.NotifyShops(new BikeModel
            {
                Name = "test",
                Type = Common.BikeType.Mountain
            });

            // Assert
            mockShop.Verify(m => m.NotifyAboutNewBike(It.IsAny<BikeModel>()), Times.Once);
        }

        [TestMethod]
        [TestCategory("Observer")]
        public void BikeManufacturer_NotifyShops_HandlesNullReferences()
        {
            // Arrange
            IBikeManufacturer manufacturer = new BikeManufacturer();
            IBikeShop mShop = new MountainBikeShop();

            WeakReference<IBikeShop> mShopRef = manufacturer.RegisterShop(mShop);

            // null out the shop
            mShop = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Act
            manufacturer.NotifyShops(new BikeModel
            {
                Name = "test",
                Type = Common.BikeType.Mountain
            });


            // Assert
            // @Markmc27 this doesn't work if I mock it because I've first got to make the 
            // unregister call virtual and then the null mShop reference doesn't seemto be null any more.
            // I think mock is caching it or copying it somewhere and preventing the GC from doing it's thing.
            //mockManufacturer.Verify(m => m.UnregisterShop(It.IsAny<WeakReference<IBikeShop>>()), Times.Once);
        }
    }
}
