using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Adapter;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        [TestCategory("Adapter")]
        public void RoadBikeProvider_AllMethods_CallCorrectMethod()
        {
            // Arrange
            Mock<IRoadBikeProvider> mockRoadBikeProvider = new Mock<IRoadBikeProvider>();

            IBikeProvider provider = new RoadBikeProviderAdapter(mockRoadBikeProvider.Object);

            // Act
            provider.CreateBike();
            provider.ReloadBike();
            provider.TransferBike();

            // Assert
            mockRoadBikeProvider.Verify(m => m.AssembleBike(), Times.Once);
            mockRoadBikeProvider.Verify(m => m.FixBike(), Times.Once);
            mockRoadBikeProvider.Verify(m => m.TransferBikeToCustomer(), Times.Once);

        }

        [TestMethod]
        [TestCategory("Adapter")]
        public void MountainBikeProvider_AllMethods_CallCorrectMethod()
        {
            // Arrange
            Mock<IMountainBikeProvider> mockMountainBikeProvider = new Mock<IMountainBikeProvider>();

            IBikeProvider provider = new MountainBikeProviderAdapter(mockMountainBikeProvider.Object);

            // Act
            provider.CreateBike();
            provider.ReloadBike();
            provider.TransferBike();

            // Assert
            mockMountainBikeProvider.Verify(m => m.BuildBike() , Times.Once);
            mockMountainBikeProvider.Verify(m => m.RepairBike(), Times.Once);
            mockMountainBikeProvider.Verify(m => m.SellBike(), Times.Once);

        }
    }
}
