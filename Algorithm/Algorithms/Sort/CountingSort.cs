namespace Algorithms.Sort;

/// <summary>
/// 计数排序
/// 1.仅适用于非负整数（或可以转换成非负整数）。
/// 2.使用于数据量大但数据范围小的情况（避免数组太长占用大量空间）。
/// </summary>
public class CountingSort
{
    /// <summary>
    /// 简单版（只支持整数）
    /// </summary>
    /// <param name="items"></param>
    public void Sort(int[] items)
    {
        if (items.Length == 0)
        {
            return;
        }

        // 1. 统计数组最大元素
        int max = items.Max();

        // 2. 统计各数字的出现次数
        int[] counters = new int[max + 1];
        foreach (int num in items)
        {
            counters[num]++;
        }

        // 3. 遍历 counter，将各元素填入原数组
        int i = 0;
        for (int num = 0; num < max + 1; num++)
        {
            for (int j = 0; j < counters[num]; j++)
            {
                items[i++] = num;
            }
        }
    }

    /// <summary>
    /// 完整版（可排序对象，并且是稳定排序）
    /// </summary>
    /// <param name="items"></param>
    public void FullSort(int[] items)
    {
        // 1. 统计数组最大元素 max
        int max = items.Max();

        // 2. 统计各数字的出现次数
        int[] counter = new int[max + 1];
        foreach (int num in items)
        {
            counter[num]++;
        }

        // 3. 求 counter 的前缀和，将“出现次数”转换为“尾索引”
        // 即 counter[num]-1 是 num 在 res 中最后一次出现的索引
        for (int i = 0; i < max; i++)
        {
            counter[i + 1] += counter[i];
        }

        // 4. 倒序遍历 items ，将各元素填入结果数组 res
        // 初始化数组 res 用于记录结果
        int n = items.Length;
        int[] res = new int[n];
        for (int i = n - 1; i >= 0; i--)
        {
            int num = items[i];
            res[counter[num] - 1] = num; // 将 num 放置到对应索引处
            counter[num]--; // 令前缀和自减 1 ，得到下次放置 num 的索引
        }

        // 使用结果数组 res 覆盖原数组 items
        for (int i = 0; i < n; i++)
        {
            items[i] = res[i];
        }
    }
}