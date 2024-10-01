namespace Algorithms.Sort;

/// <summary>
/// 冒泡排序。每一轮将最大的数移动至末尾。
/// 执行流程：
/// 4 1 3 1 5 2
/// 1 3 1 4 2 5
/// 1 3 1 2 4 5
/// 1 1 2 3 4 5
/// </summary>
public class BubbleSort
{
    public void Sort(int[] items)
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

    public void SortWithFlag(int[] items)
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
}