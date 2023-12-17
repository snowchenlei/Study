// See https://aka.ms/new-console-template for more information
using MementoPattern;

Console.WriteLine("Hello, World!");

Originator originator = new Originator();
originator.State = "On";
originator.Show();

// 创建一个备份
Caretaker caretaker = new Caretaker();
caretaker.Memento = originator.CreateMemento();

originator.State = "Off";
originator.Show();

// 恢复之前的备份
originator.SetMemento(caretaker.Memento);
originator.Show();


Console.ReadKey();