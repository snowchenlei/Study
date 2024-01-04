// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

Console.WriteLine("Hello, World!");

ConcreteComponent c = new ConcreteComponent();
ConcreteDecoratorA d1 = new ConcreteDecoratorA();
ConcreteDecoratorB d2 = new ConcreteDecoratorB();
d1.Component = c;
d2.Component = d1;
d2.Operation();

Console.ReadKey();