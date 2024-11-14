using Algorithms.Backtracking;
using Shouldly;

namespace AlgorithmTest;

public class SubsetSumTest
{
    [Theory]
    [InlineData(new int[] { 3, 4, 5 }, 9)]
    public void V1_Test(int[] nums, int target)
    {
        List<List<int>> res = new SubsetSum1().Backtrack(nums, target);
        res.Count.ShouldBeGreaterThan(0);
        res.ForEach(r => r.Sum().ShouldBe(target));
    }

    [Theory]
    [InlineData(new int[] { 3, 4, 5 }, 9)]
    public void V2_Test(int[] nums, int target)
    {
        List<List<int>> res = new SubsetSum2().Backtrack(nums, target);
        res.Count.ShouldBeGreaterThan(0);
        res.ForEach(r => r.Sum().ShouldBe(target));
    }

    [Theory]
    [InlineData(new int[] { 4, 4, 5 }, 9)]
    public void V3_Test(int[] nums, int target)
    {
        List<List<int>> res = new SubsetSum3().Backtrack(nums, target);
        res.Count.ShouldBeGreaterThan(0);
        res.ForEach(r => r.Sum().ShouldBe(target));
    }
}