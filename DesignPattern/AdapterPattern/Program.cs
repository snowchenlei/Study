// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Hello, World!");

ITarget objectTtarget = new ObjectAdapter();
objectTtarget.Request();

ITarget classTarget = new ClassAdapter();
classTarget.Request();

Console.ReadKey();