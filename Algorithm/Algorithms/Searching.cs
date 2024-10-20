using System.Formats.Tar;
using System.Numerics;

namespace Algorithms;

public class Searching
{
    /// <summary>
    /// 二分查找
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="items">元素集合</param>
    /// <param name="target">目标元素</param>
    /// <returns></returns>
    public int BinarySearch<T>(IList<T> items, T target) where T : IComparisonOperators<T, T, bool>
    {
        int i = 0, j = items.Count() - 1;
        while (i <= j)
        {
            int m = (i + j) / 2;
            T data = items[m];
            if (data < target)
            {
                i = m + 1;
            }
            else if (data > target)
            {
                j = m - 1;
            }
            else
            {
                return m;
            }
        }

        return -1;
    }

    /// <summary>
    /// 基于递归的二分查找
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="items">元素集合</param>
    /// <param name="target">目标元素</param>
    /// <returns></returns>
    public int BinarySearchWithDivideAndConquer<T>(IList<T> items, T target) where T : IComparisonOperators<T, T, bool>
    {
        return DFS(items, target, 0, items.Count - 1);
    }

    /// <summary>
    /// 二分查找
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="items">元素集合</param>
    /// <param name="target">目标元素</param>
    /// <param name="start">起始索引</param>
    /// <param name="end">结束索引</param>
    /// <returns></returns>
    private int DFS<T>(IList<T> items, T target, int start, int end) where T : IComparisonOperators<T, T, bool>
    {
        if (start > end)
        {
            return -1;
        }
        int m = (start + end) / 2;
        if (items[m] < target)
        {
            return DFS<T>(items, target, m + 1, end);
        }
        else if (items[m] > target)
        {
            return DFS<T>(items, target, start, m - 1);
        }
        else
        {
            return m;
        }
    }

    /// <summary>
    /// 二分查找插入位置
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="items">元素集合</param>
    /// <param name="target">目标元素</param>
    /// <returns></returns>
    public int BinarySearchInsertion<T>(List<T> items, T target) where T : IComparisonOperators<T, T, bool>
    {
        int i = 0, j = items.Count() - 1;
        while (i <= j)
        {
            int m = (i + j) / 2;
            T data = items[m];
            if (data < target)
            {
                i = m + 1;
            }
            else if (data > target)
            {
                j = m - 1;
            }
            else
            {
                for (int k = m; k > 0; k--)
                {
                    if (items[k] != target)
                    {
                        break;
                    }
                    m = k;
                }
                items.Insert(m, target);
                return m;
            }
        }

        return -1;
    }
}