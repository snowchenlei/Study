namespace Algorithms.Backtracking;

/// <summary>
/// 子集和。找出给定的正整数数组中和为目标正整数的所有可能。
/// 1. 元素可以多次选择。
/// </summary>
public class SubsetSum1
{
    public void Backtrack(List<int> state, int[] choices, int target, int total, List<List<int>> res)
    {
        if (IsSolution(target, total))
        {
            RecordSolution(state, res);
            return;
        }

        foreach (int choice in choices)
        {
            if (total + choice > target)
            {
                continue;
            }

            MakeChoice(state, choice);
            Backtrack(state, choices, target, total + choice, res);
            UndoChoice(state);
        }
    }

    private bool IsSolution(int target, int total)
    {
        return total == target;
    }

    private void RecordSolution(List<int> state, List<List<int>> res)
    {
        res.Add([.. state]);
    }

    private void MakeChoice(List<int> state, int choice)
    {
        state.Add(choice);
    }

    private void UndoChoice(List<int> state)
    {
        state.RemoveAt(state.Count - 1);
    }
}