namespace Algorithms.Sort;

/// <summary>
/// 希尔排序。（插入排序的优化版本。）
/// </summary>
public class ShellSort
{
    public void Sort(int[] items)
    {
        int length = items.Length,
            h = 1,
            step = 3;
        while (h < length / step)
        {
            h = step * h + 1;
        }
        while (h >= 1)
        {
            for (int i = h; i < length; i++)
            {
                int bas = items[i], j = i;
                while (j >= h && items[j - h] > bas)
                {
                    items[j] = items[j - h];
                    j -= h;
                }

                items[j] = bas;
            }
            h /= step;
        }
    }
}