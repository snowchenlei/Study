﻿namespace Algorithms.Backtracking;

/// <summary>
/// 全排列。找出一个数组排列组合的所有可能。
/// </summary>
/// <typeparam name="T"></typeparam>
public class Permutations2<T>
{
    public List<List<T>> Backtrack(T[] nums)
    {
        List<List<T>> res = new();
        Backtrack([], nums, new bool[nums.Length].ToList(), res);
        return res;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="state">行进路线</param>
    /// <param name="choices">初始数据</param>
    /// <param name="selected">标记是否选过</param>
    /// <param name="res">满足条件的结果</param>
    private void Backtrack(List<T> state, T[] choices, List<bool> selected, List<List<T>> res)
    {
        if (IsSolution(state, choices))
        {
            RecordSolution(state, res);
        }

        // 每轮同一个元素只允许选择一次
        HashSet<T> duplicated = [];
        for (int i = 0; i < choices.Length; i++)
        {
            T choice = choices[i];
            if (selected[i] || duplicated.Contains(choice))
            {
                continue;
            }

            duplicated.Add(choice);
            MakeChoice(state, selected, choice, i);
            Backtrack(state, choices, selected, res);
            UndoChoice(state, selected, i);
        }
    }

    private void UndoChoice(List<T> state, List<bool> selected, int index)
    {
        state.RemoveAt(state.Count - 1);
        selected[index] = false;
    }

    private void MakeChoice(List<T> state, List<bool> selected, T choice, int index)
    {
        selected[index] = true;
        state.Add(choice);
    }

    private bool IsSolution(List<T> state, T[] choices)
    {
        return state.Count == choices.Length;
    }

    private void RecordSolution(List<T> state, List<List<T>> res)
    {
        res.Add([.. state]);
    }
}