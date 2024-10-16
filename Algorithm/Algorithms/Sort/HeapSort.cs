namespace Algorithms.Sort;

/// <summary>
/// 堆排序（构造大顶堆并首尾交换）
/// </summary>
public class HeapSort
{
    public void Sort(int[] items)
    {
        // 建堆操作：堆化除叶节点以外的其他所有节点
        for (int i = (items.Length - 1) / 2; i >= 0; i--)
        {
            SiftDown(items, items.Length, i);
        }

        // 从堆中提取最大元素，循环 n-1 轮
        for (int i = items.Length - 1; i > 0; i--)
        {
            // 交换根节点与最右叶节点（交换首元素与尾元素）
            (items[i], items[0]) = (items[0], items[i]);
            // 以根节点为起点，从顶至底进行堆化
            SiftDown(items, i, 0);
        }
    }

    /// <summary>
    /// 自顶向底堆化
    /// </summary>
    /// <param name="items">待堆化元素</param>
    /// <param name="length">堆长度</param>
    /// <param name="i">起始节点索引</param>
    private void SiftDown(int[] items, int length, int i)
    {
        while (true)
        {
            // 判断节点 i, l, r 中值最大的节点，记为 max
            int l = 2 * i + 1,
                r = 2 * i + 2,
                max = i;

            // 左子节点值更大
            if (l < length && items[l] > items[max])
            {
                max = l;
            }
            // 右子节点值更大
            if (r < length && items[r] > items[max])
            {
                max = r;
            }
            // 若节点 i 最大或索引 l, r 越界，则跳出
            if (max == i)
            {
                break;
            }

            (items[i], items[max]) = (items[max], items[i]);
            // 循环向下堆化
            i = max;
        }
    }
}