using Patterns.Common;

namespace Patterns.Flyweight
{
    public interface IBikeRace
    {
        Competitor GetCompetitor(BikeType type);
    }
}