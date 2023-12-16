using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern;

public class FactoryB : IFactory
{
    public IProductA CreateProductA()
    {
        return new ProductAB();
    }

    public IProductB CreateProductB()
    {
        return new ProductBB();
    }
}
