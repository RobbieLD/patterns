using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Runner
{
    public abstract class BaseRunner
    {
        public void ShowTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Environment.NewLine}{this.GetType().Name} -->");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
