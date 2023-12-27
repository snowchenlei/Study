// See https://aka.ms/new-console-template for more information
using CommandPattern;

Console.WriteLine("Hello, World!");

Receive receive = new Receive();
Command command = new ConcreteCommand(receive);
Invoker invoker = new Invoker();
invoker.SetCommand(command);
invoker.ExecuteCommand();

Console.ReadKey();