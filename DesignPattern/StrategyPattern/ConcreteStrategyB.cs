using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ConcreteStrategyB : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine(nameof(ConcreteStrategyB));
        }
    }
}
