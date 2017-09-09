using System;

namespace Patterns.Behavioral.PublishSubscriber
{
    public interface IBikeShop
    {
        event EventHandler<NewBikeEventArgs> NewBikeArrivedEvent;
        void NewBikeArrived(string nameOfBike);

        string Name { get; }
    }
}
