using Algorithms.DynamicProgramming;
using Shouldly;

namespace AlgorithmTest.Algorithms;

public class ClimbingStairsTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(4, 5)]
    public void V1_Test(int num, int count)
    {
        int res = new ClimbingStairsBacktrack().ClimbingStairs(num);
        res.ShouldBe(count);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(4, 5)]
    public void V2_Test(int num, int count)
    {
        int res = new ClimbingStairsDfs().ClimbingStairs(num);
        res.ShouldBe(count);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(4, 5)]
    public void V3_Test(int num, int count)
    {
        int res = new ClimbingStairsDfsMem().ClimbingStairs(num);
        res.ShouldBe(count);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(4, 5)]
    public void V4_Test(int num, int count)
    {
        int res = new ClimbingStairsDP().ClimbingStairs(num);
        res.ShouldBe(count);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(4, 5)]
    public void V5_Test(int num, int count)
    {
        int res = new ClimbingStairsDPComp().ClimbingStairs(num);
        res.ShouldBe(count);
    }
}
