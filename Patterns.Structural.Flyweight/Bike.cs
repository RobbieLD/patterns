namespace Patterns.Structural.Flyweight
{
    public class Bike
    {
        private string _color;

        public void Paint(string color)
        {
            this._color = color;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(_color))
            {
                return "This bike isn't painted yet";
            }
            else
            {
                return string.Format("This bike is painted {0}", _color);
            }
        }
    }
}
