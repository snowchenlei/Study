namespace Algorithms.Sort;

public class ShellSort
{
    public void Sort(int[] items)
    {
        int length = items.Length,
            h = 1,
            step = 3;
        while (h < length / step)
        {
            h = step * h + 1;
        }
        while (h >= 1)
        {
            for (int i = h; i < length; i++)
            {
                for (int j = i; j >= h && items[j - h] > items[j]; j -= h)
                {
                    (items[j], items[j - h]) = (items[j - h], items[j]);
                }
            }
            h = h / step;
        }
    }
}
