using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern;

public class ConcreteFactory1 : Factory
{
    public Product CreateProduct()
    {
        return new ConcreteProduct1();
    }
}
