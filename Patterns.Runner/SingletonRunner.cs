using System;
using Patterns.Creational.Singleton;

namespace Patterns.Runner
{
    public static class SingletonRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** SINGLETON PATTERN ***{Environment.NewLine}");

            // Get the world records register instance
            BikeWorldRecordRegister register = BikeWorldRecordRegister.Instance;

            // Set the world record
            register.FastestAverageSpeedOver100Km = 43;
            register.FastestTopSpeed = 201;

            register.PrinRecords();

            register.FastestTopSpeed += 10;

            // Get another reference to the register
            BikeWorldRecordRegister registerTwo = BikeWorldRecordRegister.Instance;

            // See that this register is the same instance the previous one 
            // as the record value has changed. 
            registerTwo.PrinRecords();
        }
    }
}
