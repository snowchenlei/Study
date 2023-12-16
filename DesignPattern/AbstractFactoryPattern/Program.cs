// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;

Console.WriteLine("Hello, World!");

//IFactory factory = new FactoryA(); // new FactoryB();
//IProductA productA = factory.CreateProductA();
//IProductB productB = factory.CreateProductB();

// 简单工厂优化
IProductA? productA = SimpleFactory.CreateProductA();
IProductB? productB = SimpleFactory.CreateProductB();

productA?.DoA();
productB?.DoB();

Console.ReadKey();