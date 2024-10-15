namespace Algorithms.Sort;

public class HeapSort
{
    public void Sort(int[] items)
    {
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        foreach (int item in items)
        {
            heap.Enqueue(item);
        }
    }
}