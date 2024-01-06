// See https://aka.ms/new-console-template for more information
using PrototypePattern;

Console.WriteLine("Hello, World!");

ConcretePrototype p1 = new ConcretePrototype("1");
ConcretePrototype c1 = (ConcretePrototype)p1.Clone();
Console.WriteLine($"Cloned:{c1.Id}");

Console.ReadKey();