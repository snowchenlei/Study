namespace Algorithms.DynamicProgramming;

/// <summary>
/// 爬楼梯——回溯
/// </summary>
public class ClimbingStairsBacktrack
{
    public int ClimbingStairs(int n)
    {
        List<int> choices = [1, 2];
        int state = 0;
        List<int> res = [0];
        Backtrack(choices, state, n, res);
        return res[0];
    }

    private void Backtrack(List<int> choices, int state, int n, List<int> res)
    {
        if (state == n)
        {
            res[0]++;
        }
        foreach (int choice in choices)
        {
            if (state + choice > n)
            {
                continue;
            }
            Backtrack(choices, state + choice, n, res);
        }
    }

}
