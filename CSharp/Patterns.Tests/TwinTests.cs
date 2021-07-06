using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Structural.Twin;

namespace Patterns.Tests
{
    [TestClass]
    public class TwinTests
    {
        [TestMethod]
        [TestCategory("Twin")]
        public void HybridRoadBike_Jump_CallsJumpOnTwin()
        {
            // Arrange
            var twin = new HybridMountainBike();
            var hybrid = new HybridRoadbike
            {
                Twin = twin
            };

            // Act/Assert
            Assert.AreEqual(hybrid.Twin.Jump(), "Up up and away!");
        }

        [TestMethod]
        [TestCategory("Twin")]
        public void HybridMountainBike_Race_CallsRaceOnTwin()
        {
            // Arrange
            var twin = new HybridRoadbike();
            var hybrid = new HybridMountainBike
            {
                Twin = twin
            };

            // Act/Assert
            Assert.AreEqual(hybrid.Twin.Race(), "Racing time");
        }
    }
}
