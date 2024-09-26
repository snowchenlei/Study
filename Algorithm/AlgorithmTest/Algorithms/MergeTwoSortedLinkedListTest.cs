using Algorithms;
using Shouldly;

namespace AlgorithmTest.Algorithms;

public class MergeTwoSortedLinkedListsTest
{
    [Fact]
    public void MergeForRecursionTest_ShouldBeNull()
    {
        ListNode? node1 = null;
        ListNode? node2 = null;
        var result = new MergeTwoSortedLinkedList().MergeForRecursion(node1, node2);
        result.ShouldBeNull();
    }

    [Fact]
    public void MergeForRecursionTest()
    {
        ListNode node1 = new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(9))));
        ListNode node2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var result = new MergeTwoSortedLinkedList().MergeForRecursion(node1, node2);
        result.ShouldNotBeNull();
        result.Val.ShouldBe(1);
    }

    [Fact]
    public void MergeForCycleTest_ShouldBeNull()
    {
        ListNode? node1 = null;
        ListNode? node2 = null;
        var result = new MergeTwoSortedLinkedList().MergeForCycle(node1, node2);
        result.ShouldBeNull();
    }

    [Fact]
    public void MergeForCycleTest()
    {
        ListNode node1 = new ListNode(1, new ListNode(2, new ListNode(9)));
        ListNode node2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var result = new MergeTwoSortedLinkedList().MergeForCycle(node1, node2);
        result.ShouldNotBeNull();
        result.Val.ShouldBe(1);
    }
}