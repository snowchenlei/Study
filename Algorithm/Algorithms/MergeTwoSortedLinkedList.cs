namespace Algorithms;

public class MergeTwoSortedLinkedList
{
    public ListNode? MergeForRecursion(ListNode? l1, ListNode? l2)
    {
        if (l1 is null)
        {
            return l2;
        }
        else if (l2 is null)
        {
            return l1;
        }
        else if (l1.Val < l2.Val)
        {
            l1.Next = MergeForRecursion(l1.Next, l2);
            return l1;
        }
        else
        {
            l2.Next = MergeForRecursion(l1, l2.Next);
            return l2;
        }
    }

    public ListNode? MergeForCycle(ListNode? l1, ListNode? l2)
    {
        ListNode result = new ListNode(-1);
        ListNode prev = result;
        while (l1 is not null && l2 is not null)
        {
            if (l1.Val < l2.Val)
            {
                prev.Next = new ListNode(l1.Val);
                l1 = l1.Next;
            }
            else
            {
                prev.Next = new ListNode(l2.Val);
                l2 = l2.Next;
            }

            prev = prev.Next;
        }

        prev.Next = l1 ?? l2;
        return result.Next;
    }
}