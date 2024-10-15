using DataStructure;
using Shouldly;

namespace AlgorithmTest;

public class HeapTest
{
    protected Heap _heap;

    [Fact]
    public void IsEmpty_Test()
    {
        _heap = new Heap();
        _heap.IsEmpty().ShouldBeTrue();
    }
}