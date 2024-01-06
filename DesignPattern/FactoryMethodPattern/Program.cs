// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern;

Console.WriteLine("Hello, World!");

Factory factory = new ConcreteFactory1();
Product product = factory.CreateProduct();
product.Do();

Console.ReadKey();