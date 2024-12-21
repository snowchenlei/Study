using Algorithms;
using Shouldly;

namespace AlgorithmTest.Algorithms;

public class HanotaTest
{
    [Theory]
    [InlineData(new int[] { 5, 4, 3, 2, 1 })]
    public void RadixSortTest(int[] items)
    {
        List<int> target = new List<int>();
        new Hanota().Execute(items.ToList(), new List<int>(), target);
        target.Count.ShouldBe(items.Length);
        target[0].ShouldBe(items.Max());
        target[^1].ShouldBe(items.Min());
    }

    [Fact]
    public void RadixSortTest_Empty()
    {
        List<int> items = [];
        List<int> target = new List<int>();
        new Hanota().Execute(items, new List<int>(), target);
        target.Count.ShouldBe(0);
    }
}