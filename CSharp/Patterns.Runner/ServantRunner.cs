using Patterns.Behavioral.Servant;
using System;

namespace Patterns.Runner
{
    public class ServantRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            var mountainBike = new MountainBike();
            var roadBike = new RoadBike();

            var bikeMoveServant = new RideServant();

            Console.WriteLine($"Mountain bike status: {mountainBike}");
            bikeMoveServant.RideTo(mountainBike, 50, 10);
            Console.WriteLine($"Mountain bike is as position: {mountainBike}");

            Console.WriteLine($"Road bike status: {roadBike}");
            bikeMoveServant.RideTo(roadBike, 20, 50);
            Console.WriteLine($"Road bike is as position: {roadBike}");
        }
    }
}
