using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern;

/// <summary>
/// 对象适配器
/// </summary>
public class ObjectAdapter : ITarget
{
    private Adaptee _adaptee = new Adaptee();

    public void Request()
    {

        _adaptee.SpecificRequest();
    }
}
