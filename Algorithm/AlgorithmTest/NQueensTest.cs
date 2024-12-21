using Algorithms.Backtracking;
using Shouldly;

namespace AlgorithmTest;

public class NQueensTest
{
    [Theory]
    [InlineData(4)]
    public void Test(int n)
    {
        List<List<List<string>>> res = new NQueens().Backtrack(n);
        res.Count.ShouldBeGreaterThan(0);
    }
}