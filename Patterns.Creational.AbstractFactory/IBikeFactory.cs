namespace Patterns.Creational.AbstractFactory
{
    public interface IBikeFactory
    {
        IBike CreateBike(string name);
    }
}
