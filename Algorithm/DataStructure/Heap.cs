namespace DataStructure;

/// <summary>
/// 堆（满足特定条件的完全二叉树。分为大顶堆和小顶堆）
/// </summary>
public class Heap
{
    private readonly List<int> _maxHeap = [];

    public bool IsEmpty()
    {
        return Size() == 0;
    }

    public int Size()
    {
        return _maxHeap.Count;
    }

    /// <summary>
    /// 访问堆顶元素
    /// </summary>
    /// <returns></returns>
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new IndexOutOfRangeException();
        }
        return _maxHeap[0];
    }

    public int Parent(int i)
    {
        return (i - 1) / 2;
    }

    public int Left(int i)
    {
        return 2 * i + 1;
    }

    public int Right(int i)
    {
        return 2 * i + 2;
    }

    /// <summary>
    /// 入堆
    /// </summary>
    /// <param name="val">要入堆的元素</param>
    public void Push(int val)
    {
        _maxHeap.Add(val);
    }

    /// <summary>
    /// 出堆
    /// </summary>
    /// <returns>出堆的元素</returns>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public int Pop()
    {
        if (IsEmpty())
        {
            throw new IndexOutOfRangeException();
        }
        // 交换首尾元素
        Swap(0, Size() - 1);
        int val = _maxHeap.Last();
        _maxHeap.RemoveAt(Size() - 1);
        SiftDown(0);
        return val;
    }

    /// <summary>
    /// 从顶至底堆化
    /// </summary>
    /// <param name="i">节点i</param>
    private void SiftDown(int i)
    {
        while (true)
        {
            // 判断节点 i, l, r 中值最大的节点，记为 max
            int l = Left(i), r = Right(i), max = i;
            if (l < Size() && _maxHeap[l] > _maxHeap[max])
                max = l;
            if (r < Size() && _maxHeap[r] > _maxHeap[max])
                max = r;
            // 若“节点 i 最大”或“越过叶节点”，则结束堆化
            if (max == i) break;
            // 交换两节点
            Swap(i, max);
            // 循环向下堆化
            i = max;
        }
    }

    /// <summary>
    /// 从底至顶堆化
    /// </summary>
    /// <param name="i">节点i</param>
    public void SiftUp(int i)
    {
        while (true)
        {
            // 获取节点 i 的父节点
            int p = Parent(i);
            // 若“越过根节点”或“节点无须修复”，则结束堆化
            if (p < 0 || _maxHeap[p] >= _maxHeap[i])
            {
                break;
            }
            // 交换两节点
            Swap(i, p);
            // 循环向上堆化
            i = p;
        }
    }

    private void Swap(int i, int j)
    {
        (_maxHeap[i], _maxHeap[j]) = (_maxHeap[j], _maxHeap[i]);
    }
}