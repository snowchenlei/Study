using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern;

/// <summary>
/// 类适配器
/// </summary>
public class ClassAdapter : Adaptee, ITarget
{
    public void Request()
    {
        base.SpecificRequest();
    }
}
