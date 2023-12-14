using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern;

public class ConcreteObserver : Observer
{
    private readonly string _name;
    private readonly ConcreteSubject _subject;

    public ConcreteObserver(ConcreteSubject subject, string name)
    {
        _subject = subject;
        _name = name;
    }
    public void Update()
    {
        Console.WriteLine($"观察者{_name}的状态是{_subject.SubjectState}");
    }
}
