namespace Algorithms.Sort;

public class MergeSort
{
    public void Sort(int[] items, int left, int right)
    {
        if (left >= right)
        {
            return;
        }
        int mid = left + (right - left) / 2;
        Sort(items, left, mid);
        Sort(items, mid + 1, right);

        Merge(items, left, mid, right);
    }

    private void Merge(int[] items, int left, int mid, int right)
    {
        int i = left, j = mid + 1, k = 0;
        int[] temps = new int[right - left + 1];

        // 循环将小的元素优先插入数组
        while (i <= mid && j <= right)
        {
            if (items[i] <= items[j])
            {
                temps[k++] = items[i++];
            }
            else
            {
                temps[k++] = items[j++];
            }
        }

        // 拷贝剩余的元素
        while (i <= mid)
        {
            temps[k++] = items[i++];
        }

        while (j <= right)
        {
            temps[k++] = items[j++];
        }

        // 将临时数组的元素拷贝到原数组
        for (k = 0; k < temps.Length; k++)
        {
            items[left + k] = temps[k];
        }
    }
}