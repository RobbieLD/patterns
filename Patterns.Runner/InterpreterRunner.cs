using System;
using Patterns.Behavioral.Interpreter;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Runner
{
    public static class InterpreterRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** INTERPRETER PATTERN ***{Environment.NewLine}");

            Bike imperialBike = new Bike
            {
                BikeWeight = new Measurment
                {
                    Amount = 10,
                    Unit = Unit.Lb
                },
                TirePressure = new Measurment
                {
                    Amount = 60,
                    Unit = Unit.Psi
                },
                WheelSize = new Measurment
                {
                    Amount = 29,
                    Unit = Unit.Inch
                }
            };

            // Create the context
            Context context = new Context(imperialBike);

            // Create the expression list
            List<Expression> expressions = new List<Expression>();
            expressions.Add(new WeightExpression());
            expressions.Add(new DistanceExpression());
            expressions.Add(new PressureExpression());

            // Interpreter
            foreach(Expression exp in expressions)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"Unconverted Bike: {context.UnconvertedBike}");
            Console.WriteLine($"Converted Bike: {context.ConvertedBike}");

        }
    }
}
