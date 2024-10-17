namespace Algorithms.Sort;

/// <summary>
/// 桶排序（需要根据数据规律设计分桶方法）
/// 1.根据数据规律设计分桶方法划分桶
/// 2.将数据均匀的放到各桶中
/// 3.对每个桶的数据分别进行排序
/// 4.合并所有桶数据
/// </summary>
public class BucketSort
{
    public void Sort(decimal[] items)
    {
        // 初始化桶
        int k = items.Length / 2;
        List<List<decimal>> buckets = [];
        for (int i = 0; i < k; i++)
        {
            buckets.Add([]);
        }

        // 元素入桶
        foreach (decimal item in items)
        {
            int i = (int)(item * k);
            buckets[i].Add(item);
        }

        // 桶分别排序
        foreach (List<decimal> bucket in buckets)
        {
            bucket.Sort();
        }

        // 合并桶
        int j = 0;
        foreach (List<decimal> bucket in buckets)
        {
            foreach (decimal num in bucket)
            {
                items[j++] = num;
            }
        }
    }
}