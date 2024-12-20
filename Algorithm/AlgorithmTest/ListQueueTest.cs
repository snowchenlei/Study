﻿using DataStructure;

namespace AlgorithmTest;

public class ListQueueTest() : QueueTest(new ListQueue<int>())
{
    [Theory]
    [InlineData(5)]
    [InlineData(99)]
    [InlineData(1242)]
    public void ListEnqueueTest(int value)
    {
        EnqueueTest(value);
    }

    [Fact]
    public void ListDequeueTest()
    {
        DequeueTest();
    }

    [Fact]
    public void ListPeekTest()
    {
        PeekTest();
    }
}