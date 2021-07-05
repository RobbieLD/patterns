using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.Servant;

namespace Patterns.Tests
{
    [TestClass]
    public class ServantTests
    {
        [TestMethod]
        [TestCategory("Servant")]
        public void RideServant_RideTo_MovesBike()
        {
            // Arrange
            var servant = new RideServant();
            var bike = new MountainBike();

            // Act
            servant.RideTo(bike, 10, 100);

            // Assert
            Assert.AreEqual(bike.Position.X, 17.36);
            Assert.AreEqual(bike.Position.Y, 98.48);
        }
    }
}
