namespace Patterns.Behavioral.Servant
{
    public class CoordinatePair
    {
        public double X { get; }
        public double Y { get; }

        public CoordinatePair(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.X, this.Y);
        }
    }
}
