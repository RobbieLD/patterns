using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.State;

namespace Patterns.Tests
{
    [TestClass]
    public class StateTests
    {

        [TestMethod]
        [TestCategory("State")]
        public void Bike_AddComponent_ChangesState()
        {
            // Arrange
            Bike bike = new Bike("Rob");

            System.Type firstType = bike.State.GetType();

            // Act
            bike.Add(ComponentType.Shocks);

            System.Type secondType = bike.State.GetType();

            // Assert
            Assert.IsFalse(firstType == secondType);
        }
    }
}
