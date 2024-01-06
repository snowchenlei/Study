using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern;

public class ConcreteProduct1 : Product
{
    public void Do()
    {
        Console.WriteLine($"{nameof(ConcreteProduct1)}做");
    }
}
