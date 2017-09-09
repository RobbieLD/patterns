using System;
using System.Collections.Generic;
using Patterns.Behavioral.Stratergy;

namespace Patterns.Runner
{
    public static class StratergyRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** STRATERGY PATTERN ***{Environment.NewLine}");

            IBike mountainBike = new MountainBike();

            // Build with default instructions
            mountainBike.BuildBike();

            mountainBike.ChangeInstructions(new List<IInstruction>
            {
                new FrameInstruction(),
                new BrakesInstruction(),
                new LightsInstruction(),
                new WheelsInstruction(),
                new ShocksInstruction()
            });

            // Build with new instructions. 
            mountainBike.BuildBike();
        }
    }
}
