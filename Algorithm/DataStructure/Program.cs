namespace DataStructure
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> items = new List<int>();
            items.Insert(1, 10);

            int[] nums = [1, 2, 3, 4, 5, 6];
            ArrayDs array = new ArrayDs();
            array.Insert(nums, 99, 3);
            Console.Write("Inserted……:");
            foreach (int num in nums)
            {
                Console.Write(" " + num);
            }

            Console.WriteLine();
            Console.WriteLine("99's index: " + array.FindIndex(nums, 99));
            Console.Write("Random Get:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" " + array.RandomAccess(nums));
            }

            Console.WriteLine();
            array.Delete(nums, 2);
            Console.Write("Deleted……:");
            foreach (int num in nums)
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            int[] results = array.Extend(nums, 3);
            Console.WriteLine("Extend: " + results.Length);

            Console.ReadKey();
        }
    }
}