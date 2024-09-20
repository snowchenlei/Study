namespace DataStructure;

public class ArrayDs
{
    public int RandomAccess(int[] nums)
    {
        if (nums.Length == 0)
        {
            throw new ArgumentException();
        }

        Random random = new();
        int randomIndex = random.Next(nums.Length);
        int randomNum = nums[randomIndex];
        return randomNum;
    }

    public void Insert(int[] nums, int num, int index)
    {
        if (index > nums.Length)
        {
            return;
        }

        for (int i = nums.Length - 1; i > index; i--)
        {
            nums[i] = nums[i - 1];
        }

        nums[index] = num;
    }

    public void Delete(int[] nums, int index)
    {
        for (int i = index; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }

        nums[^1] = default;
    }

    public int FindIndex(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    public int[] Extend(int[] nums, int enlarge)
    {
        int[] res = new int[nums.Length + enlarge];
        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = nums[i];
        }

        return res;
    }
}