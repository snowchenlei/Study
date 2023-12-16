using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern;

public class ProductAB : IProductA
{
    public void DoA()
    {
        Console.WriteLine(nameof(ProductAB));
    }
}
