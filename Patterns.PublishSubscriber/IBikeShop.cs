using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.PublishSubscriber
{
    public interface IBikeShop
    {
        event EventHandler<NewBikeEventArgs> NewBikeArrivedEvent;
        void NewBikeArrived(string nameOfBike);

        string Name { get; }
    }
}
