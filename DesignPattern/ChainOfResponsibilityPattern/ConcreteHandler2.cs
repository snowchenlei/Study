using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern;

public class ConcreteHandler2: Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
        {
            Console.WriteLine($"{this.GetType().Name}处理请求{request}");
        }
        else if (Successor is not null)
        {
            Successor.HandleRequest(request);
        }
    }
}
