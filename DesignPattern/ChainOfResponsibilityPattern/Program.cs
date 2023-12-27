// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilityPattern;

Console.WriteLine("Hello, World!");

Handler h1 = new ConcreteHandler1();
Handler h2 = new ConcreteHandler2();
Handler h3 = new ConcreteHandler3();
h1.Successor = h2;
h2.Successor = h3;

int[] requests =new int[] { 2, 5, 14, 22, 18, 3, 27, 30 };
foreach (var request in requests)
{
    h1.HandleRequest(request);
}

Console.ReadKey();