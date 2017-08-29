using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Stratergy
{
    public class MountainBike : IBike
    {
        private List<IInstruction> _instructions = new List<IInstruction>
        {
            new FrameInstruction(),
            new WheelsInstruction(),
            new BrakesInstruction(),
            new ShocksInstruction(),
            new LightsInstruction()
        };

        public void BuildBike()
        {
            Console.WriteLine("Building Mountain Bike");

            _instructions.ForEach(i => i.AddComponent());
        }


        public void ChangeInstructions(List<IInstruction> instruction)
        {
            _instructions = instruction;
        }
    }
}
