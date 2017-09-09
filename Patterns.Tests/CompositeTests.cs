using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Structural.Compisite;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class CompositeTests
    {
        [TestMethod]
        [TestCategory("Composite")]
        public void AbstractBike_Display_CallDisplayMethodOfChildren()
        {
            // Arrange
            PrototypeBike basicBike = new PrototypeBike("BasicBike");

            PrototypeBike basicMountainBike = new PrototypeBike("BasicMountainBike");

            basicBike.Add(basicMountainBike);

            Mock<AbstractBike> mockAbstractBike = new Mock<AbstractBike>("TEST");

            basicMountainBike.Add(mockAbstractBike.Object);
            
            // Act
            basicBike.Display();

            // Assert
            mockAbstractBike.Verify(m => m.Display(It.IsAny<int>()), Times.Once);
        }
    }
}
