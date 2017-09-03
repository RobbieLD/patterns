using System;

namespace Patterns.Runner
{
    public abstract class AbstractRunner
    {
        public virtual void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** ABSTRACT FACTORY PATTERN ***{Environment.NewLine}");
        }
    }
}
