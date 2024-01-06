using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern;

public class Proxy : Subject
{
    RealSubject? realSubject;
    public void Request()
    {
        if(realSubject is null)
        {
            realSubject = new RealSubject();
        }
        realSubject.Request();
    }
}
