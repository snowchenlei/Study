using Algorithms;
using Shouldly;

namespace AlgorithmTest.Algorithms;

public class ReverseLinkedListTest
{
    [Fact]
    public void MergeForCycle1Test_ShouldByNull()
    {
        ListNode? node1 = null;
        var result = new ReverseLinkedList().ReverseForCycle1(node1);
        result.ShouldBeNull();
    }

    [Fact]
    public void MergeForCycle1Test()
    {
        ListNode node1 = new ListNode(1, new ListNode(2, new ListNode(9)));
        var result = new ReverseLinkedList().ReverseForCycle1(node1);
        result.ShouldNotBeNull();
        result.Val.ShouldBe(9);
    }

    [Fact]
    public void MergeForCycle2Test_ShouldByNull()
    {
        ListNode? node1 = null;
        var result = new ReverseLinkedList().ReverseForCycle2(node1);
        result.ShouldBeNull();
    }

    [Fact]
    public void MergeForCycle2Test()
    {
        ListNode node1 = new ListNode(1, new ListNode(2, new ListNode(9)));
        var result = new ReverseLinkedList().ReverseForCycle2(node1);
        result.ShouldNotBeNull();
        result.Val.ShouldBe(9);
    }

    [Fact]
    public void ReverseForRecursionTest_ShouldByNull()
    {
        ListNode? node1 = null;
        var result = new ReverseLinkedList().ReverseForRecursion(node1);
        result.ShouldBeNull();
    }

    [Fact]
    public void ReverseForRecursionTest()
    {
        ListNode node1 = new ListNode(1, new ListNode(2, new ListNode(9)));
        var result = new ReverseLinkedList().ReverseForRecursion(node1);
        result.ShouldNotBeNull();
        result.Val.ShouldBe(9);
    }
}