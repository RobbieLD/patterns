using System;

namespace Patterns.Behavioral.Visitor
{
    public class TirePumpRobot : IRobot
    {
        public void DoWork(IBike bike)
        {
            // adjust the pressure in the tires
            switch(bike.Type)
            {
                case Common.BikeType.Hybrid:
                    bike.TirePressure += new Random().Next(-20, 20);
                    break;
                case Common.BikeType.Mountain:
                    bike.TirePressure += new Random().Next(-5, 5);
                    break;
                case Common.BikeType.Road:
                    bike.TirePressure += new Random().Next(-40, 40);
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"{bike.Type} isn't a supported bike type");
            }
        }
    }
}
