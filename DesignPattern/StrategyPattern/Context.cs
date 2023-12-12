using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {
        private readonly IStrategy _strategy;

        public Context(string type)
        {
            _strategy = type switch
            {
                "A" => new ConcreteStrategyA(),
                "B" => new ConcreteStrategyA(),
                _ => throw new NotImplementedException(),
            };
        }

        public void Execute()
        {
            _strategy.Algorithm();
        }
    }
}
