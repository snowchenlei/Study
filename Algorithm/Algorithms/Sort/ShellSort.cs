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
            new InsertionSort().SortImpl(items, h);
            h /= step;
        }
    }
}