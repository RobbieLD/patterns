using System;
using System.Linq.Expressions;

namespace Patterns.Behavioral.Specification
{
    public class IsBikeType : Specification<Bike>
    {
        private readonly BikeType _type;

        public IsBikeType(BikeType type)
        {
            _type = type;
        }

        public override Expression<Func<Bike, bool>> ToExpression()
        {
            return bike => bike.BikeType == _type;
        }
    }
}
