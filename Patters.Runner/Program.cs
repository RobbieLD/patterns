using System;


namespace Patterns.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decorator Pattern
            DecoratorRunner.Run();
            
            // Wait for user
            Console.ReadKey();
             
        }
    }
}