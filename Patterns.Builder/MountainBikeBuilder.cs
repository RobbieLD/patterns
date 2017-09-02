namespace Patterns.Builder
{
    public class MountainBikeBuilder : BikeBuilder
    {
        public MountainBikeBuilder()
        {
            Bike = new Bike("Mountain Bike");
        }

        public override void AddBrakes()
        {
            Bike["brakes"] = "Shimano Dior";
        }

        public override void AddWheels()
        {
            Bike["wheels"] = "Armadillos";
        }

        public override void AddFrame()
        {
            Bike["frame"] = "Giant GT 2.0";
        }
    }
}
