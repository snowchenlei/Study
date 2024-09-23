using DataStructure;

namespace AlgorithmTest;

public class LinkedListStackTest() : StackTest(new LinkedListStack<int>())
{
    [Theory]
    [InlineData(5)]
    [InlineData(99)]
    [InlineData(1242)]
    public void ListPushTest(int value)
    {
        PushTest(value);
    }

    [Fact]
    public void ListPopTest()
    {
        PopTest();
    }

    [Fact]
    public void ListPeekTest()
    {
        PeekTest();
    }
}