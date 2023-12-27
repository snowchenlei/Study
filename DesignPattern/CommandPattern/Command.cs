using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;

public abstract class Command
{
    protected Receive Receive { get; private set; }

    public Command(Receive receive)
    {
        Receive = receive;
    }

    public abstract void Execute();
}
