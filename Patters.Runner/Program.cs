using System;


namespace Patterns.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decorator Pattern
            DecoratorRunner.Run();

            // Temaplte Pattern
            TemplateRunner.Run();

            // Wait for user
            Console.ReadKey();
             
        }
    }
}