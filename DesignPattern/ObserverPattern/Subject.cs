using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern;

public class Subject
{
    private List<Observer> _observers = new List<Observer>();

    /// <summary>
    /// 增加观察者
    /// </summary>
    /// <param name="observer">观察者</param>
    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    /// <summary>
    /// 移除观察者
    /// </summary>
    /// <param name="observer">观察者</param>
    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (Observer observer in _observers)
        {
            observer.Update();
        }
    }
}
