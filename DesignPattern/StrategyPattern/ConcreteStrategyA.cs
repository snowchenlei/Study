using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ConcreteStrategyA : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine(nameof(ConcreteStrategyA));
        }
    }
}
