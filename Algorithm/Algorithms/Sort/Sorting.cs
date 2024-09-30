using System.Globalization;

namespace Algorithms.Sort;

public class Sorting
{
    /// <summary>
    /// 选择排序。每一轮获取最小的索引与当前首位索引互换。
    /// </summary>
    /// <param name="items"></param>
    public void SelectionSort(int[] items)
    {
        for (int i = 0; i < items.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < items.Length; j++)
            {
                if (items[minIndex] > items[j])
                {
                    minIndex = j;
                }
            }

            (items[i], items[minIndex]) = (items[minIndex], items[i]);
        }
    }

    /// <summary>
    /// 冒泡排序。每一轮将最大的数移动至末尾。
    /// 执行流程：
    /// 4 1 3 1 5 2
    /// 1 3 1 4 2 5
    /// 1 3 1 2 4 5
    /// 1 1 2 3 4 5
    /// </summary>
    /// <param name="items"></param>
    public void BubbleSort(int[] items)
    {
        for (int i = items.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (items[j] > items[j + 1])
                {
                    (items[j], items[j + 1]) = (items[j + 1], items[j]);
                }
            }
        }
    }

    public void BubbleSortWithFlag(int[] items)
    {
        for (int i = items.Length - 1; i > 0; i--)
        {
            bool orderly = true;
            for (int j = 0; j < i; j++)
            {
                if (items[j] > items[j + 1])
                {
                    orderly = false;
                    (items[j], items[j + 1]) = (items[j + 1], items[j]);
                }
            }

            if (orderly)
            {
                break;
            }
        }
    }

    /// <summary>
    /// 插入排序。
    /// </summary>
    /// <param name="items"></param>
    public void InsertionSort(int[] items)
    {
        for (int i = 1; i < items.Length; i++)
        {
            int bas = items[i], j = i;
            while (j > 0 && items[j - 1] > bas)
            {
                items[j] = items[j - 1];
                j--;
            }

            items[j] = bas;
        }
    }
}