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

            // PublishSubscriber Pattern
            PublishSubscribeRunner.Run();

            // Factory Pattern
            FactoryRunner.Run();

            // Abstract Factory Pattern
            AbstractFactoryRunner.Run();

            // Wait for user
            Console.ReadKey();
             
        }
    }
}