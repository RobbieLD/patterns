namespace Patterns.Builder
{
    public class RoadBikeBuilder : BikeBuilder
    {
        public RoadBikeBuilder()
        {
            Bike = new Bike("Road Bike");
        }

        public override void AddBrakes()
        {
            Bike["brakes"] = "Shimano Acera";
        }

        public override void AddWheels()
        {
            Bike["wheels"] = "Maxis";
        }

        public override void AddFrame()
        {
            Bike["frame"] = "Specialized";
        }
    }
}
