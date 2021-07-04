using System.Collections.Generic;

namespace Patterns.Behavioral.Stratergy
{
    public interface IBike
    {
        void BuildBike();
        void ChangeInstructions(List<IInstruction> instruction);
    }
}
