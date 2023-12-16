using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern;

public class Context
{
    private IState state;
    public IState State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("当前状态：" + state.GetType().Name);
        } 
    }

    public Context(IState state)
    {
        State = state;
    }

    public void Request()
    {
        State.Handle(this);
    }
}
