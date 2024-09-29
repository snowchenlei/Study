using Algorithms;
using Shouldly;

namespace AlgorithmTest.Algorithms;

public class SearchingTest
{
    [Theory]
    [InlineData(new int[]{ 1, 2, 3 }, 2, 1)]
    [InlineData(new int[] { 1, 2, 3 }, 3, 2)]
    [InlineData(new int[] { 1, 2, 3 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 4, 3 }, 4, 2)]
    [InlineData(new int[] { 1, 2, 4, 3 }, 2, 1)]
    public void BinarySearch(int[] items, int target, int targetIndex)
    {
        int index = new Searching().BinarySearch(items, target);
        index.ShouldBe(targetIndex);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2, 1)]
    [InlineData(new int[] { 1, 2, 2, 2, 3 }, 2, 1)]
    public void BinarySearchInsertion(int[] items, int target, int targetIndex)
    {
        int index = new Searching().BinarySearchInsertion(items.ToList(), target);
        index.ShouldBe(targetIndex);
    }
}