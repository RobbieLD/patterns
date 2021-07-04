namespace Patterns.Behavioral.Interpreter
{
    public class Measurment
    {
        public Unit Unit { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"{Amount} {Unit}";
        }
    }
}
