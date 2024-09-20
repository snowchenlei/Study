using DataStructure;
using Shouldly;

namespace AlgorithmTest;

public class LinkedListDsTest
{
    [Fact]
    public void AddTest()
    {
        IListDs<int> items = new LinkedListDs<int>();
        items.Add(1);
        items.Add(2);
        items.Add(3);
    }
}