using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern;

public class ProductBA : IProductB
{
    public void DoB()
    {
        Console.WriteLine(nameof(ProductBA));
    }
}
