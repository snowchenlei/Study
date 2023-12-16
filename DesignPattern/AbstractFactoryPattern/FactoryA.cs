using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern;

public class FactoryA : IFactory
{
    public IProductA CreateProductA()
    {
       return new ProductAA();
    }

    public IProductB CreateProductB()
    {
        return new ProductBA();
    }
}
