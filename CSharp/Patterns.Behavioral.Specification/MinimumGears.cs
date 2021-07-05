using System;
using System.Linq.Expressions;

namespace Patterns.Behavioral.Specification
{
    public class MinimumGears : Specification<Bike>
    {
        private readonly int _minimumGears;

        public MinimumGears(int numberOfGears)
        {
            _minimumGears = numberOfGears;
        }

        public override Expression<Func<Bike, bool>> ToExpression()
        {
            return bike => bike.Gears >= _minimumGears;
        }
    }
}
