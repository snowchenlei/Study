using Algorithms.Sort;
using Shouldly;

namespace AlgorithmTest.Algorithms;

public class SortingTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void SelectionSortTest(int[] items)
    {
        new SelectionSort().Sort(items);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void SelectionSort_Empty()
    {
        int[] items = [];
        new SelectionSort().Sort(items);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void BubbleSortTest(int[] items)
    {
        new BubbleSort().Sort(items);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void BubbleSortTest_Empty()
    {
        int[] items = [];
        new BubbleSort().Sort(items);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void BubbleSortWithFlagTest(int[] items)
    {
        new BubbleSort().SortWithFlag(items);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void BubbleSortWithFlagTest_Empty()
    {
        int[] items = [];
        new BubbleSort().SortWithFlag(items);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void InsertionSortTest(int[] items)
    {
        new InsertionSort().Sort(items);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void InsertionSortTest_Empty()
    {
        int[] items = [];
        new InsertionSort().Sort(items);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void QuickSortTest(int[] items)
    {
        new QuickSort().Sort(items, 0, items.Length - 1);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void QuickSortTest_Empty()
    {
        int[] items = [];
        new QuickSort().Sort(items, 0, items.Length);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void QuickSortWithSwapTest(int[] items)
    {
        new QuickSort().SortWithSwap(items, 0, items.Length - 1);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void QuickSortWithSwapTest_Empty()
    {
        int[] items = [];
        new QuickSort().SortWithSwap(items, 0, items.Length);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void SortWithMedianTest(int[] items)
    {
        new QuickSort().SortWithMedian(items, 0, items.Length - 1);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void SortWithMedianTest_Empty()
    {
        int[] items = [];
        new QuickSort().SortWithMedian(items, 0, items.Length);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void SortWithTailRecursionTest(int[] items)
    {
        new QuickSort().SortWithTailRecursion(items, 0, items.Length - 1);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void SortWithTailRecursionTest_Empty()
    {
        int[] items = [];
        new QuickSort().SortWithTailRecursion(items, 0, items.Length);
        items.Length.ShouldBe(0);
    }
}