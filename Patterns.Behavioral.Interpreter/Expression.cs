namespace Patterns.Behavioral.Interpreter
{
    public abstract class Expression
    {
        public abstract void Interpret(Context context);

        protected abstract double ConversionFactor();
        protected abstract Unit ConversionUnit();

        protected Measurment ConvertMeasurment(Measurment oldMeasurment)
        {
            return new Measurment
            {
                Unit = ConversionUnit(),
                Amount = oldMeasurment.Amount * ConversionFactor()
            };
        }
    }
}
