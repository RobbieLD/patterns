using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Structural.Flyweight;

namespace Patterns.Tests
{
    [TestClass]
    public class FlyweightTests
    {
        [TestMethod]
        [TestCategory("Flyweight")]
        public void PaintRobots_Paint_PaintsBike()
        {
            // Arrange
            var greenBike = new Bike();
            var redBike = new Bike();

            // Act
            var greenRobotA = PaintRobotFactory.GetRobot("green");
            greenRobotA.PaintBike(greenBike);

            var redRobot = PaintRobotFactory.GetRobot("red");
            redRobot.PaintBike(redBike);

            // Assert 
            Assert.AreEqual(redBike.ToString(), "This bike is painted red");
        }

        [TestMethod]
        [TestCategory("Flyweight")]
        public void PaintRobotFactory_GetRobot_ReusesRobots()
        {
            // Arrange/Act
            var greenPaintRobotA = PaintRobotFactory.GetRobot("green");
            var greenPaintRobotB = PaintRobotFactory.GetRobot("green");
            var redPaintRobot = PaintRobotFactory.GetRobot("red");

            // Assert
            Assert.AreEqual(greenPaintRobotB, greenPaintRobotA);
            Assert.AreNotEqual(greenPaintRobotB, redPaintRobot);
        }
    }
}
