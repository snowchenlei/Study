using System.Numerics;

namespace Algorithms;

public class Searching
{
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
