namespace Algorithms.DynamicProgramming;

public class ClimbingStairsDfsMem
{
    public int ClimbingStairs(int n)
    {
        int[] mem = new int[n + 1];
        Array.Fill(mem, -1);
        return Dfs(n, mem);
    }

    private int Dfs(int n, int[] mem)
    {
        if (n == 1 || n == 2)
        {
            return n;
        }
        if (mem[n] != -1)
        {
            return mem[n];
        }
        int count = Dfs(n - 1, mem) + Dfs(n - 2, mem);
        mem[n] = count;
        return count;
    }
}
