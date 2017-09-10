namespace Patterns.Behavioral.Interpreter
{
    public class PressureExpression : Expression
    {
        protected override double ConversionFactor()
        {
            return 6.89476;
        }

        protected override Unit ConversionUnit()
        {
            return Unit.Kpa;
        }

        public override void Interpret(Context context)
        {
            context.ConvertedBike.TirePressure = ConvertMeasurment(context.UnconvertedBike.TirePressure);
        }
    }
}
