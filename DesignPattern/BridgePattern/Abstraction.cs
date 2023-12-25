using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern;

public class Abstraction
{
    public Implementor? Implementor { get; private set; }

    public void SetImplementor(Implementor implementor)
    {
        Implementor = implementor;
    }

    public virtual void Operation()
    {
        Implementor?.Operation();
    }
}
