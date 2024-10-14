namespace Algorithms.Sort;

/// <summary>
/// 快速排序。（二分策略。从右找比其小的，从左找比其大的，交换数据）
/// </summary>
public class QuickSort
{
    /// <summary>
    /// 基础版。通过赋值实现
    /// </summary>
    /// <param name="items"></param>
    /// <param name="left"></param>
    /// <param name="right"></param>
    public void Sort(int[] items, int left, int right)
    {
        if (left >= right)
        {
            return;
        }
        int pivot = Partition(items, left, right);
        Sort(items, left, pivot - 1);
        Sort(items, pivot + 1, right);
    }

    /// <summary>
    /// 交换数据版
    /// </summary>
    /// <param name="items"></param>
    /// <param name="left"></param>
    /// <param name="right"></param>
    public void SortWithSwap(int[] items, int left, int right)
    {
        if (left >= right)
        {
            return;
        }
        int pivot = PartitionWithSwap(items, left, right);
        SortWithSwap(items, left, pivot - 1);
        SortWithSwap(items, pivot + 1, right);
    }

    /// <summary>
    /// 基准数优化版
    /// </summary>
    /// <param name="items"></param>
    /// <param name="left"></param>
    /// <param name="right"></param>
    public void SortWithMedian(int[] items, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        if (items.Length > 3)
        {
            int median = GetMedianThree(items, left, items[(left + right) / 2], right);
            Swap(items, left, median);
        }

        int pivot = PartitionWithSwap(items, left, right);
        Sort(items, left, pivot - 1);
        Sort(items, pivot + 1, right);
    }

    /// <summary>
    /// 交换数据版
    /// </summary>
    /// <param name="items"></param>
    /// <param name="left"></param>
    /// <param name="right"></param>
    public void SortWithTailRecursion(int[] items, int left, int right)
    {
        while (left < right)
        {
            int pivot = PartitionWithSwap(items, left, right);
            if (pivot - left < right - pivot)
            {
                Sort(items, left, pivot - 1);
                left = pivot + 1;  // 剩余未排序区间为 [pivot + 1, right]
            }
            else
            {
                Sort(items, pivot + 1, right);
                right = pivot - 1; // 剩余未排序区间为 [left, pivot - 1]
            }
        }
    }

    /// <summary>
    /// 取3个数的中位数
    /// </summary>
    /// <param name="items"></param>
    /// <param name="left"></param>
    /// <param name="middle"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    private int GetMedianThree(int[] items, int left, int middle, int right)
    {
        int l = items[left], m = items[middle], r = items[right];
        if ((l <= m && m <= r) || (r <= m && m <= l))
            return middle; // m 在 l 和 r 之间
        if ((m <= l && l <= r) || (r <= l && l <= m))
            return left; // l 在 m 和 r 之间
        return right;
    }

    private int Partition(int[] items, int left, int right)
    {
        int i = left, j = right, pivot = items[left];
        while (i < j)
        {
            while (i < j && items[j] >= pivot)
            {
                j--;
            }

            items[i] = items[j];

            while (i < j && items[i] <= pivot)
            {
                i++;
            }
            items[j] = items[i];
        }

        items[i] = pivot;
        return i;
    }

    private int PartitionWithSwap(int[] items, int left, int right)
    {
        int i = left, j = right, pivot = items[left];
        while (i < j)
        {
            while (i < j && items[j] >= pivot)
            {
                j--;
            }

            while (i < j && items[i] <= pivot)
            {
                i++;
            }
            // ignore i == j;
            Swap(items, i, j);
        }
        Swap(items, i, left);

        return i;
    }

    private void Swap(int[] items, int i, int j)
    {
        (items[j], items[i]) = (items[i], items[j]);
    }
}