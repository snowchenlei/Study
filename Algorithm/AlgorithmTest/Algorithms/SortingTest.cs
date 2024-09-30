using Algorithms;
using Shouldly;
using Xunit.Abstractions;

namespace AlgorithmTest.Algorithms;

public class SortingTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void SelectionSortTest(int[] items)
    {
        new Sorting().SelectionSort(items);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void SelectionSort_Empty()
    {
        int[] items = [];
        new Sorting().SelectionSort(items);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void BubbleSortTest(int[] items)
    {
        new Sorting().BubbleSort(items);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void BubbleSortTest_Empty()
    {
        int[] items = [];
        new Sorting().SelectionSort(items);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void BubbleSortWithFlagTest(int[] items)
    {
        new Sorting().BubbleSortWithFlag(items);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void BubbleSortWithFlagTest_Empty()
    {
        int[] items = [];
        new Sorting().BubbleSortWithFlag(items);
        items.Length.ShouldBe(0);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 8, 2, 4, 2, 3, 9, 16, 25 })]
    public void InsertionSortTest(int[] items)
    {
        new Sorting().InsertionSort(items);
        items.Length.ShouldBe(items.Length);
        items[0].ShouldBe(items.Min());
        items[^1].ShouldBe(items.Max());
    }

    [Fact]
    public void InsertionSortTest_Empty()
    {
        int[] items = [];
        new Sorting().InsertionSort(items);
        items.Length.ShouldBe(0);
    }
}