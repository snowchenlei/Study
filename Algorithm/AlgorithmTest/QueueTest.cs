using DataStructure;
using Shouldly;

namespace AlgorithmTest;

public class QueueTest
{
    protected readonly IQueue<int> _queue;

    public QueueTest(IQueue<int> queue)
    {
        _queue = queue ?? throw new ArgumentNullException(nameof(queue));
    }

    public void EnqueueTest(int value)
    {
        _queue.Enqueue(value);
        _queue.GetCount().ShouldBe(1);
    }

    public void DequeueTest()
    {
        InitialData();
        int val = _queue.Dequeue();
        _queue.GetCount().ShouldBe(3);
        val.ShouldBe(1);
    }

    public void PeekTest()
    {
        InitialData();
        int val = _queue.Peek();
        _queue.GetCount().ShouldBe(4);
        val.ShouldBe(1);
    }

    protected void InitialData()
    {
        _queue.Enqueue(1);
        _queue.Enqueue(2);
        _queue.Enqueue(3);
        _queue.Enqueue(4);
    }
}