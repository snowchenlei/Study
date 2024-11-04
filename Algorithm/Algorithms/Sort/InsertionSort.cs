namespace Algorithms.Sort;

/// <summary>
/// 插入排序。
/// </summary>
public class InsertionSort
{
    public void Sort(int[] items)
    {
        SortImpl(items, 1);
    }

    public void SortImpl(int[] items, int h)
    {
        for (int i = h; i < items.Length; i++)
        {
            int bas = items[i], j = i;
            while (j >= h && items[j - h] > bas)
            {
                items[j] = items[j - h];
                j -= h;
            }

            items[j] = bas;
        }
    }
}