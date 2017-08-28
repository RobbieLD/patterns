using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.PublishSubscriber
{
    public class BikeShop : IBikeShop
    {
        public BikeShop(string nameOfShop)
        {
            Name = nameOfShop;
        }
        public string Name { get; }

        public event EventHandler<NewBikeEventArgs> NewBikeArrivedEvent;

        public delegate void NewBikeEventHandler(object sender, NewBikeEventArgs args);

        public void NewBikeArrived(string nameOfBike)
        {
            // Raise the event that a new bike has arrived
            OnNewBikeArrivedEvent(new NewBikeEventArgs(nameOfBike));
        }

        protected virtual void OnNewBikeArrivedEvent(NewBikeEventArgs args)
        {
            /**
             * There is a race condition we could encounter here where 
             * after we've done the null check (because event programing is multithreaded)
             * the last subscriber unsubscribes. So we make a copy of the event to avoid that
             */
            EventHandler<NewBikeEventArgs> handler = NewBikeArrivedEvent;

            // If there are no subscribers this will be null
            // so there's no point in publishing it. 
            if(handler != null)
            {
                handler(this, args);
            }
        }

    }
}
