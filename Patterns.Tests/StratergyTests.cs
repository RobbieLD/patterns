using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Patterns.Stratergy;
using System.Collections.Generic;

namespace Patterns.Tests
{
    [TestClass]
    public class StratergyTests
    {
        [TestMethod]
        [TestCategory("Stratergy")]
        public void MountainBike_BuildBike_CallsInstructions()
        {
            // Arrange
            IBike bike = new MountainBike();
            Mock<IInstruction> inst = new Mock<IInstruction>();
            // Act
            bike.BuildBike();
            bike.ChangeInstructions(new List<IInstruction> { inst.Object });
            bike.BuildBike();

            // Assert
            inst.Verify(i => i.AddComponent(), Times.Once);
        }
    }
}
