using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern;

public class ConcreteMediator : Mediator
{
    public ConcreteColleague1? colleague1 { get; set; }
    public ConcreteColleague2? colleague2 { get; set; }
    public override void Send(string message, Colleague colleague)
    {
        if (colleague == colleague1)
        {
            colleague2?.Notify(message);
        }
        else
        {
            colleague1?.Notify(message);
        }
    }
}
