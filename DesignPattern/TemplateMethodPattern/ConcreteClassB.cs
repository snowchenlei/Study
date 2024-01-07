using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern;

public class ConcreteClassB : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine($"{nameof(ConcreteClassB)}方法1实现");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine($"{nameof(ConcreteClassB)}方法2实现");
    }
}
