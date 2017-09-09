using Patterns.Common;

namespace Patterns.Structural.Flyweight
{
    public interface IBikeRace
    {
        Competitor GetCompetitor(BikeType type);
    }
}
