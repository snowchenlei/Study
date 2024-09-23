using DataStructure;
using Shouldly;
using System;
using System.Management;

namespace AlgorithmTest;

public class LinkedListDsTest
{
    [Fact]
    public void IsEmpty_NotEmpty()
    {
        IListDs<int> items = GetItems(5);
        items.IsEmpty().ShouldBeFalse();
    }

    [Fact]
    public void IsEmpty_Empty()
    {
        IListDs<int> items = new SequenceList<int>();
        items.IsEmpty().ShouldBeTrue();
    }

    [Fact]
    public void GetLengthTest()
    {
        IListDs<int> items = new SequenceList<int>();

        items.GetLength().ShouldBe(0);
    }

    [Fact]
    public void AddTest()
    {
        int count = 5;
        IListDs<int> items = GetItems(count);
        items.Add(999);
        items.GetLength().ShouldBe(count + 1);
    }

    [Theory]
    [InlineData(5, 90, 3)]
    [InlineData(5, 45, 3)]
    [InlineData(5, 158, 3)]
    public void InsertTest(int count, int value, int index)
    {
        IListDs<int> items = GetItems(count);
        items.Insert(value, index);
        items.GetLength().ShouldBe(count + 1);
        items.GetElement(index).ShouldBe(value);
    }

    [Fact]
    public void DeleteTest()
    {
        int count = 5;
        IListDs<int> items = GetItems(count);
        items.Delete(2).ShouldBe(3);
        items.GetLength().ShouldBe(count - 1);
    }

    [Theory]
    [InlineData(5, -1)]
    [InlineData(5, 5)]
    [InlineData(5, 6)]
    public void Delete_ArgumentOutOfRangeException(int count, int index)
    {
        IListDs<int> items = GetItems(count);
        Should.Throw<ArgumentOutOfRangeException>(() =>
        {
            items.Delete(index);
        });
    }

    [Theory]
    [InlineData(5, 3)]
    [InlineData(5, 0)]
    public void GetElementTest(int count, int index)
    {
        IListDs<int> items = GetItems(count);
        items.GetElement(index).ShouldBe(index + 1);
    }

    [Theory]
    [InlineData(5, -1)]
    [InlineData(5, 5)]
    [InlineData(5, 6)]
    public void GetElement_ArgumentOutOfRangeException(int count, int index)
    {
        IListDs<int> items = GetItems(count);
        Should.Throw<ArgumentOutOfRangeException>(() =>
        {
            items.GetElement(index);
        });
    }

    [Theory]
    [InlineData(5, 1)]
    [InlineData(5, 5)]
    public void FindIndex(int count, int value)
    {
        IListDs<int> items = GetItems(count);
        items.FindIndex(value).ShouldBe(value - 1);
    }

    [Fact]
    public void FindIndex_ArgumentOutOfRangeException()
    {
        IListDs<int> items = new LinkedListDs<int>();
        Should.Throw<ArgumentOutOfRangeException>(() =>
        {
            items.GetElement(1);
        });
    }

    [Theory]
    [InlineData(5, -1)]
    [InlineData(5, 6)]
    public void FindIndex_NotFound(int count, int value)
    {
        IListDs<int> items = GetItems(count);
        items.FindIndex(value).ShouldBe(-1);
    }

    private IListDs<int> GetItems(int count)
    {
        IListDs<int> items = new LinkedListDs<int>();
        for (int i = 1; i <= count; i++)
        {
            items.Add(i);
        }
        return items;
    }
}