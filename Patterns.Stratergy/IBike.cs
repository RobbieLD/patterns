using System.Collections.Generic;

namespace Patterns.Stratergy
{
    public interface IBike
    {
        void BuildBike();
        void ChangeInstructions(List<IInstruction> instruction);
    }
}
