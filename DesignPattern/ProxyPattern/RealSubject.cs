using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern;

public class RealSubject : Subject
{
    public void Request()
    {
        Console.WriteLine("真实的请求");
    }
}
