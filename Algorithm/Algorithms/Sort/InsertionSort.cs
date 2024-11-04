namespace Algorithms.Sort;

/// <summary>
/// 插入排序。
/// </summary>
public class InsertionSort
{
    public void Sort(int[] items)
    {
        for (int i = 1; i < items.Length; i++)
        {
            int bas = items[i], j = i;
            while (j >= 1 && items[j - 1] > bas)
            {
                items[j] = items[j - 1];
                j--;
            }

            items[j] = bas;
        }
    }
}