namespace Algorithms.Backtracking;

/// <summary>
/// N皇后问题。将n个皇后放置在n*n大小的棋盘上。
/// 1. 同一行、同一列、同一对角线有且仅有一个皇后
///
/// 矩阵的主对角线上所有格子row-col值相等；次对角线上所有格子row+col值相等。
/// n维方阵中row-col的范围是[-n+1, n-1]；row+col的范围是[0, 2n-2]。
/// </summary>
public class NQueens
{
    /// <summary>
    /// 按照从上往下、从左往右的顺序
    /// </summary>
    /// <param name="count">皇后数量</param>
    /// <returns></returns>
    public List<List<List<string>>> Backtrack(int count)
    {
        List<List<string>> state = new();
        for (int i = 0; i < count; i++)
        {
            List<string> row = new();
            for (int j = 0; j < count; j++)
            {
                row.Add("#");
            }
            state.Add(row);
        }
        bool[] cols = new bool[count];
        bool[] mainDiagonals = new bool[2 * count - 1];
        bool[] minorDiagonals = new bool[2 * count - 1];
        List<List<List<string>>> res = [];
        Backtrack(count, 0, state, res, cols, mainDiagonals, minorDiagonals);
        return res;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="count">皇后数</param>
    /// <param name="row">行数</param>
    /// <param name="state">矩阵</param>
    /// <param name="res">结果</param>
    /// <param name="cols">列标记</param>
    /// <param name="mainDiagonals">主对角线标记</param>
    /// <param name="minorDiagonals">次对角线标记</param>
    private void Backtrack(int count, int row, List<List<string>> state, List<List<List<string>>> res, bool[] cols,
        bool[] mainDiagonals, bool[] minorDiagonals)
    {
        if (IsSolution(count, row))
        {
            RecordSolution(state, res);
            return;
        }

        for (int col = 0; col < count; col++)
        {
            // row和col在矩阵索引的取值范围是[0, n-1]，row-col数值范围是[-n+1, n-1]，而数组的索引不为负值（[0, 2n-2]），所以需要+n-1。
            int mainDiagonal = row - col + count - 1;
            int minorDiagonal = row + col;
            if (cols[col] || mainDiagonals[mainDiagonal] || minorDiagonals[minorDiagonal])
            {
                continue;
            }

            MakeChoice(row, col, state, cols, mainDiagonals, minorDiagonals, mainDiagonal, minorDiagonal);
            Backtrack(count, row + 1, state, res, cols, mainDiagonals, minorDiagonals);
            UndoChoice(row, col, state, cols, mainDiagonals, minorDiagonals, mainDiagonal, minorDiagonal);
        }
    }

    private bool IsSolution(int n, int row)
    {
        // 摆放到了最后一行
        return row == n;
    }

    private void RecordSolution(List<List<string>> state, List<List<List<string>>> res)
    {
        List<List<string>> copyState = [];
        foreach (List<string> item in state)
        {
            copyState.Add([.. item]);
        }
        res.Add([.. copyState]);
    }

    private void MakeChoice(int row, int col, List<List<string>> state, bool[] cols,
        bool[] mainDiagonals, bool[] minorDiagonals, int mainDiagonal, int minorDiagonal)
    {
        state[row][col] = "Q";
        cols[col] = mainDiagonals[mainDiagonal] = minorDiagonals[minorDiagonal] = true;
    }

    private void UndoChoice(int row, int col, List<List<string>> state, bool[] cols,
        bool[] mainDiagonals, bool[] minorDiagonals, int mainDiagonal, int minorDiagonal)
    {
        state[row][col] = "#";
        cols[col] = mainDiagonals[mainDiagonal] = minorDiagonals[minorDiagonal] = false;
    }
}