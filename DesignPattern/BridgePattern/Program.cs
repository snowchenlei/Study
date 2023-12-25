// See https://aka.ms/new-console-template for more information
using BridgePattern;

Console.WriteLine("Hello, World!");

Abstraction ab = new Abstraction();

ab.SetImplementor(new ConcreteImplementorA());
ab.Operation();

ab.SetImplementor(new ConcreteImplementorB());
ab.Operation();

Console.ReadKey();