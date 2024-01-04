using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern;

public abstract class Decorator : Component
{
    public Component? Component { get; set; }

    public virtual void Operation()
    {
        if(Component is not null)
        {
            Component.Operation();
        }
    }
}
