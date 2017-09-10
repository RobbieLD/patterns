using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.Interpreter;

namespace Patterns.Tests
{
    [TestClass]
    public class InterpreterTests
    {
        [TestMethod]
        [TestCategory("Interpreter")]
        public void WeightExpression_Interpret_CorrectlyInterpretsWeight()
        {
            // Arrange
            Bike imperialBike = new Bike
            {
                BikeWeight = new Measurment
                {
                    Amount = 10,
                    Unit = Unit.Lb
                }
            };

            Context context = new Context(imperialBike);
            Expression exp = new WeightExpression();
            
            // Act
            exp.Interpret(context);

            // Assert
            Assert.AreEqual(context.ConvertedBike.BikeWeight.Amount, 4.53592);
        }

        [TestMethod]
        [TestCategory("Interpreter")]
        public void PressureExpression_Interpret_CorrectlyInterpretsWeight()
        {
            // Arrange
            Bike imperialBike = new Bike
            {
                TirePressure = new Measurment
                {
                    Amount = 60,
                    Unit = Unit.Psi
                }
            };

            Context context = new Context(imperialBike);
            Expression exp = new PressureExpression();

            // Act
            exp.Interpret(context);

            // Assert
            Assert.AreEqual(context.ConvertedBike.TirePressure.Amount, 413.68559999999997);
        }

        [TestMethod]
        [TestCategory("Interpreter")]
        public void WheelSizeExpression_Interpret_CorrectlyInterpretsWeight()
        {
            // Arrange
            Bike imperialBike = new Bike
            {
                WheelSize = new Measurment
                {
                    Amount = 29,
                    Unit = Unit.Inch
                }
            };

            Context context = new Context(imperialBike);
            Expression exp = new DistanceExpression();

            // Act
            exp.Interpret(context);

            // Assert
            Assert.AreEqual(context.ConvertedBike.WheelSize.Amount, 73.66);
        }
    }
}
