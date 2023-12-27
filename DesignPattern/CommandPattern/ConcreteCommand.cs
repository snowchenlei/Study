using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;

public class ConcreteCommand : Command
{
    public ConcreteCommand(Receive receive) : base(receive)
    {
    }

    public override void Execute()
    {
        Receive.Action();
    }
}
