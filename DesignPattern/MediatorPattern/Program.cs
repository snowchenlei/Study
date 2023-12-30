// See https://aka.ms/new-console-template for more information
using MediatorPattern;

Console.WriteLine("Hello, World!");

ConcreteMediator m = new ConcreteMediator();

ConcreteColleague1 c1 = new ConcreteColleague1(m);
ConcreteColleague2 c2 = new ConcreteColleague2(m);

m.colleague1 = c1;
m.colleague2 = c2;

c1.Send("吃饭了吗？");
c2.Send("没有呢");

Console.ReadKey();