using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern;

public abstract class Colleague
{
    protected Mediator Mediator { get; private set; }

    public Colleague(Mediator mediator)
    {
        Mediator = mediator;
    }
}
