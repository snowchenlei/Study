using Algorithms.Backtracking;
using DataStructure.Tree;
using Shouldly;

namespace AlgorithmTest;

public class PermutationTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 })]
    public void V1_Test(int[] nums)
    {
        List<List<int>> res = new();
        new Permutations1<int>().Backtrack([], nums.ToList(), new bool[nums.Length].ToList(), res);
        res.Count.ShouldBe(6);
        res.ForEach(r => r.Count.ShouldBe(3));
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 3 })]
    public void V2_Test(int[] nums)
    {
        List<List<int>> res = new();
        new Permutations2<int>().Backtrack([], nums.ToList(), new bool[nums.Length].ToList(), res);
        res.Count.ShouldBe(3);
        res.ForEach(r => r.Count.ShouldBe(3));
    }
}