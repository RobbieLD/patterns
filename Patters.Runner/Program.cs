using System;


namespace Patterns.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton Pattern
            SingletonRunner.Run();

            // Decorator Pattern
            DecoratorRunner.Run();

            // Temaplte Pattern
            TemplateRunner.Run();

            // Observer Pattern
            ObserverRunner.Run();

            // Wait for user
            Console.ReadKey();
             
        }
    }
}