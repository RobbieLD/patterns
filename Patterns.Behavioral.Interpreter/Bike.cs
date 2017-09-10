using System;

namespace Patterns.Behavioral.Interpreter
{
    /// <summary>
    /// Just a data class to hold the information to interpret
    /// </summary>
    public class Bike
    {
        public Measurment WheelSize { get; set; }
        public Measurment TirePressure { get; set; }
        public Measurment BikeWeight { get; set; }

        public override string ToString()
        {
            return $"Wheel: {WheelSize}, Tires: {TirePressure}, Weight: {BikeWeight}";
        }
    }
}
