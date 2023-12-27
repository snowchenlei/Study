using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;

public class Invoker
{
    protected Command? Command { get; private set; }

    public void SetCommand(Command command)
    {
        Command = command;
    }

    public void ExecuteCommand()
    {
        Command?.Execute();
    }
}
