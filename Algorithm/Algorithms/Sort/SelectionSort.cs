namespace Algorithms.Sort;

/// <summary>
/// 选择排序。每一轮获取最小的索引与当前首位索引互换。
/// </summary>
/// <param name="items"></param>
public class SelectionSort
{
    public void Sort(int[] items)
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
}