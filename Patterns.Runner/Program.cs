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

            // Stratergy Pattern
            StratergyRunner.Run();

            // Prototype Pattern
            PrototypeRunner.Run();

            // Builder Pattern
            BuilderRunner.Run();

            // Adapter Pattern
            AdapterRunner.Run();

            // Facade Pattern
            FacadeRunner.Run();

            // Command Pattern
            CommandRunner.Run();

            // Memento Pattern
            MementoRunner.Run();

            // Wait for user
            Console.ReadKey();
             
        }
    }
}