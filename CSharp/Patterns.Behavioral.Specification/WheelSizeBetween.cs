using System;
using System.Linq.Expressions;

namespace Patterns.Behavioral.Specification
{
    public class WheelSizeBetween : Specification<Bike>
    {
        private readonly int _maxWheelSize;
        private readonly int _minWheelSize;

        public WheelSizeBetween(int maxWheelSize, int minWheelSize)
        {
            _maxWheelSize = maxWheelSize;
            _minWheelSize = minWheelSize;
        }

        public override Expression<Func<Bike, bool>> ToExpression()
        {
            return bike => bike.WheelSize <= _maxWheelSize && bike.WheelSize >= _minWheelSize;
        }
    }
}
