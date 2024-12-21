namespace Algorithms.DynamicProgramming;

public class ClimbingStairsDPComp
{
    public int ClimbingStairs(int n)
    {
        if(n == 1 || n == 2)
        {
            return n;
        }
        int a = 1, b = 2;
        for (int i = 3; i <= n; i++)
        {
            (a, b) = (b, a + b);
        }
        return b;
    }
}
