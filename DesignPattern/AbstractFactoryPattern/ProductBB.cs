using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern;

public class ProductBB : IProductB
{
    public void DoB()
    {
        Console.WriteLine(nameof(ProductBB));
    }
}
