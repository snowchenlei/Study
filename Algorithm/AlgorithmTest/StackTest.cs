using DataStructure;
using Shouldly;

namespace AlgorithmTest;

public class StackTest
{
    protected readonly IStack<int> _stack;

    public StackTest(IStack<int> stack)
    {
        _stack = stack ?? throw new ArgumentNullException(nameof(stack));
    }

    public void PushTest(int value)
    {
        _stack.Push(value);
        _stack.GetCount().ShouldBe(1);
    }

    public void PopTest()
    {
        InitialData();
        int val = _stack.Pop();
        _stack.GetCount().ShouldBe(3);
        val.ShouldBe(4);
    }

    public void PeekTest()
    {
        InitialData();
        int val = _stack.Peek();
        _stack.GetCount().ShouldBe(4);
        val.ShouldBe(4);
    }

    protected void InitialData()
    {
        _stack.Push(1);
        _stack.Push(2);
        _stack.Push(3);
        _stack.Push(4);
    }
}