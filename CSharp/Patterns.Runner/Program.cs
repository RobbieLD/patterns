using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Patterns.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = new ServiceCollection()
                .RegisterAllTypes<IRunner>(new[] { typeof(Program).Assembly })
                .BuildServiceProvider();


            foreach(var runner in serviceProvider.GetServices<IRunner>())
            {
                runner.Run();
            }

        }
    }
}