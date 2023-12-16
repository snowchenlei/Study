// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Console.WriteLine("Hello, World!");

Director director = new Director();

Builder b1 = new ConcreteBuilder1();
Builder b2 = new ConcreteBuilder2();

director.Construct(b1);
Product p1 = b1.GetResult();
p1.Show();

director.Construct(b2);
Product p2 = b2.GetResult();
p2.Show();

// 避免必填属性过多导致构造函数太长，如果通过Set方法又无法关联校验的问题。
// 通过建造者模式创建不可变对象
ResourceConfig config = new ResourceConfig.Builder()
    .SetName("dbconnection")
    .SetMaxTotal(16)
    .SetMaxIdle(10)
    .SetMinIdle(12)
    .Build();

Console.ReadLine();