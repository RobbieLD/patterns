namespace Patterns.Behavioral.Interpreter
{
    public class WeightExpression : Expression
    {
        protected override double ConversionFactor()
        {
            return 0.453592;
        }

        protected override Unit ConversionUnit()
        {
            return Unit.Kg;
        }

        public override void Interpret(Context context)
        {
            context.ConvertedBike.BikeWeight = ConvertMeasurment(context.UnconvertedBike.BikeWeight);
        }

    }
}
