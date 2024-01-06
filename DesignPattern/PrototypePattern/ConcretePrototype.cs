using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern;

public class ConcretePrototype : Prototype
{
    public ConcretePrototype(string id) : base(id)
    {
    }

    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}
