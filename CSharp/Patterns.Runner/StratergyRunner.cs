using System;
using System.Collections.Generic;
using Patterns.Behavioral.Stratergy;

namespace Patterns.Runner
{
    public class StratergyRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

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
