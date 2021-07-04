using System;

namespace Patterns.Behavioral.PublishSubscriber
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
