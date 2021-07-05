using System;
using System.Linq.Expressions;

namespace Patterns.Behavioral.Specification
{
    public class MaximumGears : Specification<Bike>
    {
        private readonly int _maximumGears;

        public MaximumGears(int numberOfGears)
        {
            _maximumGears = numberOfGears;
        }

        public override Expression<Func<Bike, bool>> ToExpression()
        {
            return bike => bike.Gears <= _maximumGears;
        }
    }
}
