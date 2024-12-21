namespace Algorithms.Backtracking;

/// <summary>
/// 子集和。找出给定的正整数数组中和为目标正整数的所有可能。
/// 1. 元素可以多次选择。
/// 2. 子集合不区分元素顺序。{4,5}和{5,4}相同。
/// </summary>
public class SubsetSum2
{
    public List<List<int>> Backtrack(int[] nums, int target)
    {
        List<List<int>> res = new();
        Array.Sort(nums);
        Backtrack([], nums, target, 0, res);
        return res;
    }

    public void Backtrack(List<int> state, int[] choices, int target, int start, List<List<int>> res)
    {
        if (IsSolution(target))
        {
            RecordSolution(state, res);
            return;
        }

        for (int i = start; i < choices.Length; i++)
        {
            int choice = choices[i];
            if (target - choice < 0)
            {
                break;
            }

            MakeChoice(state, choice);
            Backtrack(state, choices, target - choice, i, res);
            UndoChoice(state);
        }
    }

    private bool IsSolution(int target)
    {
        return target == 0;
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