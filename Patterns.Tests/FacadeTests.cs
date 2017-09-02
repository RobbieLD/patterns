using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Facade;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class FacadeTests
    {
        [TestMethod]
        [TestCategory("Facade")]
        public void PartsSupplier_GetMethods_CallCorrectSuppliers()
        {
            // Arrange
            Mock<ITomsPartsSupplier> mockTom = new Mock<ITomsPartsSupplier>();
            Mock<IDicksBikeBits> mockDick = new Mock<IDicksBikeBits>();
            Mock<IHarrysJunkYard> mockHarry = new Mock<IHarrysJunkYard>();

            IPartsSupplier supplier = new PartsSupplier(mockTom.Object, mockDick.Object, mockHarry.Object);

            // Act
            supplier.GetBrakes();
            supplier.GetWheels();
            supplier.GetShocks();

            // Assert
            mockTom.Verify(t => t.GetBrakes(), Times.Once);
            mockTom.Verify(t => t.GetShocks(), Times.Never);
            mockTom.Verify(t => t.GetWheels(), Times.Never);

            mockDick.Verify(t => t.GetWheels(), Times.Once);

            mockHarry.Verify(t => t.GetBrakes(), Times.Never);
            mockHarry.Verify(t => t.GetShocks(), Times.Once);

        }
    }
}
