using System.Collections.Generic;

namespace Patterns.Behavioral.Specification
{
    public interface IRepository<T>
    {
        IReadOnlyList<T> Find(Specification<T> specification);
    }
}
