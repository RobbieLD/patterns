using System;

namespace Patterns.Behavioral.Servant
{
    public interface IBike
    {
        void SetPosition(CoordinatePair coordinates);
        CoordinatePair Position { get; }
        int Speed { get; }
        DateTime Time { get; set; }
    }
}
