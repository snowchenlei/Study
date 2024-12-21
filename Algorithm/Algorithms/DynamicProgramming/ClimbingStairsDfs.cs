namespace Algorithms.DynamicProgramming;

public class ClimbingStairsDfs
{
    public int ClimbingStairs(int n)
    {
        return Dfs(n);
    }

    public int Dfs(int n)
    {
        if(n == 1 || n == 2)
        {
            return n;
        }
        int count = Dfs(n-1)+ Dfs(n-2);
        return count;
    }
}
