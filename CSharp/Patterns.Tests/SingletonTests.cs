using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Creational.Singleton;

namespace Patterns.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        [TestCategory("Singletone")]
        public void WorldRecordRegister_Instantiation_OnlyCreatesSingleInstance()
        {
            // Arrange
            BikeWorldRecordRegister registerOne = BikeWorldRecordRegister.Instance;
            BikeWorldRecordRegister registerTwo = BikeWorldRecordRegister.Instance;

            // Act
            registerOne.FastestTopSpeed = 100;
            

            // Assert
            // Assert.AreSame makes sure the two objects are pointing to the same memory
            // Assert.Equals simply does a value compare
            Assert.AreSame(registerOne, registerTwo);
            Assert.AreEqual(registerOne.FastestTopSpeed, registerTwo.FastestTopSpeed);

        }

    }
}
