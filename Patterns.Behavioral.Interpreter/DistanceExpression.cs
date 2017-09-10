namespace Patterns.Behavioral.Interpreter
{
    public class DistanceExpression : Expression
    {
        public override void Interpret(Context context)
        {
            context.ConvertedBike.WheelSize = ConvertMeasurment(context.UnconvertedBike.WheelSize);
        }

        protected override double ConversionFactor()
        {
            return 2.54;
        }

        protected override Unit ConversionUnit()
        {
            return Unit.Cm;
        }
    }
}
