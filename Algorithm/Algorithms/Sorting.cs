using System.Globalization;

namespace Algorithms;

public class Sorting
{
    public void SelectionSort(int[] items)
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