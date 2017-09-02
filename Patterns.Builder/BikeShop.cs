namespace Patterns.Builder
{
    public class BikeShop
    {
        public void Build(BikeBuilder builder)
        {
            builder.AddFrame();
            builder.AddWheels();
            builder.AddBrakes();

        }
    }
}
