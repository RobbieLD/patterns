using System;

namespace Patterns.PublishSubscriber
{
    public class NewBikeEventArgs : EventArgs
    {
        public string NameOfBike{ get; }

        public NewBikeEventArgs(string nameOfNewBike)
        {
            NameOfBike = nameOfNewBike;
        }
    }
}
