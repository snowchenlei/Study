using System.Xml.Serialization;

namespace Algorithms;

/// <summary>
/// 汉诺塔问题
/// </summary>
public class Hanota
{
    public void Execute(List<int> a, List<int> b, List<int> c)
    {
        int length = a.Count;
        if (length == 0) return;
        DFS(length, a, b, c);
    }

    /// <summary>
    /// 求解问题
    /// </summary>
    /// <param name="length">圆盘的长度</param>
    /// <param name="source">原集合</param>
    /// <param name="buf">临时集合</param>
    /// <param name="target">目标集合</param>
    private void DFS(int length, List<int> source, List<int> buf, List<int> target)
    {
        if (length == 1)
        {
            Move(source, target);
            return;
        }
        DFS(length - 1, source, target, buf);
        Move(source, target);
        DFS(length - 1, buf, source, target);
    }

    /// <summary>
    /// 将最后一个元素从<see cref="source"/>移动到<see cref="target"/>.
    /// </summary>
    /// <param name="source">原集合</param>
    /// <param name="target">目标集合</param>
    private void Move(List<int> source, List<int> target)
    {
        int pan = source[^1];
        source.Remove(pan);
        target.Add(pan);
    }
}