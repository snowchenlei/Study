// See https://aka.ms/new-console-template for more information
using ObserverPattern;

Console.WriteLine("Hello, World!");

var s = new ConcreteSubject();
s.Attach(new ConcreteObserver(s, "X"));
s.Attach(new ConcreteObserver(s, "Y"));
s.Attach(new ConcreteObserver(s, "Z"));

s.SubjectState = "ABC";
s.Notify();

Console.ReadLine();