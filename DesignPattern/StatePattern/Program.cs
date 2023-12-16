// See https://aka.ms/new-console-template for more information
using StatePattern;

Console.WriteLine("Hello, World!");

Context context = new Context(new ConcreteStateA());

context.Request();
context.Request();
context.Request();
context.Request();

Console.ReadKey();