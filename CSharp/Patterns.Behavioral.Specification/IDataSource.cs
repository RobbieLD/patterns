using System.Linq;

namespace Patterns.Behavioral.Specification
{
    public interface IDataSource<T>
    {
        IQueryable<T> Bikes();
    }
}
