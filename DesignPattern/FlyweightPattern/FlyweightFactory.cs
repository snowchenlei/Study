using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern;

public class FlyweightFactory
{
    public Dictionary<string, Flyweight> Flyweights { get; set; }
    public FlyweightFactory()
    {
        Flyweights = new Dictionary<string, Flyweight>()
        {
            ["X"] = new ConcreteFlyweight(),
            ["Y"] = new ConcreteFlyweight(),
            ["Z"] = new ConcreteFlyweight(),
        };
    }

    public Flyweight GetFlyweight(string key)
    {
        return Flyweights[key];
    }
}
