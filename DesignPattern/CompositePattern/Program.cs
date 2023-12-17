// See https://aka.ms/new-console-template for more information
using CompositePattern;

Console.WriteLine("Hello, World!");

Composite root = new Composite("root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));

Composite comp = new Composite("Composite X");
comp.Add(new Leaf("Leaf XA"));
comp.Add(new Leaf("Leaf XB"));

root.Add(comp);

Composite comp2 = new Composite("Composite XY");
comp2.Add(new Leaf("Leaf XYA"));
comp2.Add(new Leaf("Leaf XYB"));

root.Add(comp2);

root.Add(new Leaf("Leaf C"));

Leaf leaf = new Leaf("Leaf D");
root.Add(leaf);
root.Remove(leaf);

root.Display(1);

Console.ReadKey();
