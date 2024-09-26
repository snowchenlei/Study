namespace Algorithms;

public class ReverseLinkedList
{
    public ListNode? ReverseForCycle1(ListNode? head)
    {
        if (head is null)
        {
            return null;
        }
        ListNode? l2 = null;
        while (head is not null)
        {
            l2 = new ListNode(head.Val, l2);
            head = head.Next;
        }
        return l2;
    }

    public ListNode? ReverseForCycle2(ListNode? head)
    {
        ListNode? current = head;
        ListNode? prev = null;
        while (current is not null)
        {
            ListNode? next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }

    public ListNode? ReverseForRecursion(ListNode? head)
    {
        if (head is null || head.Next is null)
        {
            return head;
        }

        ListNode? current = ReverseForRecursion(head.Next);
        head.Next.Next = head;
        head.Next = null;
        return current;
    }
}