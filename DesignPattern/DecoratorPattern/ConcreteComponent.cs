using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern;

public class ConcreteComponent : Component
{
    public void Operation()
    {
        Console.WriteLine("具体对象的操作");
    }
}
