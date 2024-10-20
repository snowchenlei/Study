namespace Algorithms.Sort;

/// <summary>
/// 基数排序（按位计数排序）
/// </summary>
public class RadixSort
{
    public void Sort(int[] items)
    {
        // 获取数组的最大元素，用于判断最大位数
        int m = int.MinValue;
        foreach (int num in items)
        {
            if (num > m) m = num;
        }
        // 按照从低位到高位的顺序遍历
        for (int exp = 1; exp <= m; exp *= 10)
        {
            // 对数组元素的第 k 位执行计数排序
            // k = 1 -> exp = 1
            // k = 2 -> exp = 10
            // 即 exp = 10^(k-1)
            CountingSortDigit(items, exp);
        }
    }

    /// <summary>
    /// 计数排序（根据 items 第 k 位排序）
    /// </summary>
    /// <param name="items"></param>
    /// <param name="exp"></param>
    private void CountingSortDigit(int[] items, int exp)
    {
        // 十进制的位范围为 0~9 ，因此需要长度为 10 的桶数组
        int[] counter = new int[10];
        int n = items.Length;

        // 统计 0~9 各数字的出现次数
        for (int i = 0; i < n; i++)
        {
            // 获取 items[i] 第 k 位，记为 d
            int d = Digit(items[i], exp);
            // 统计数字 d 的出现次数
            counter[d]++;
        }

        // 求前缀和，将“出现个数”转换为“数组索引”
        for (int i = 1; i < 10; i++)
        {
            counter[i] += counter[i - 1];
        }

        // 倒序遍历，根据桶内统计结果，将各元素填入 res
        int[] res = new int[n];
        for (int i = n - 1; i >= 0; i--)
        {
            int d = Digit(items[i], exp);
            // 获取 d 在数组中的索引 j
            int j = counter[d] - 1;
            // 将当前元素填入索引 j
            res[j] = items[i];
            // 将 d 的数量减 1
            counter[d]--;
        }

        // 使用结果覆盖原数组 items
        for (int i = 0; i < n; i++)
        {
            items[i] = res[i];
        }
    }

    /// <summary>
    /// 获取元素 num 的第 k 位，其中 exp = 10^(k-1)
    /// </summary>
    /// <param name="num"></param>
    /// <param name="exp"></param>
    /// <returns></returns>
    private int Digit(int num, int exp)
    {
        // 传入 exp 而非 k 可以避免在此重复执行昂贵的次方计算
        return (num / exp) % 10;
    }
}