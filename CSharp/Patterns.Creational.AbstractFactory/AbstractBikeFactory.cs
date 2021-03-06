﻿namespace Patterns.Creational.AbstractFactory
{
    public abstract class AbstractBikeFactory : IBikeFactory
    {
        public abstract IBike CreateBike(string name);
    }
}
