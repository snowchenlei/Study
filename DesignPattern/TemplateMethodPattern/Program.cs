// See https://aka.ms/new-console-template for more information
using TemplateMethodPattern;

Console.WriteLine("Hello, World!");

AbstractClass c = new ConcreteClassA();
c.TemplateMethod();

c = new ConcreteClassB();
c.TemplateMethod();

Console.ReadKey();