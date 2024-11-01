using DataStructure.Tree;

namespace Algorithms.Backtracking;

public class TreeSearch : BacktrackBase
{
    /// <summary>
    /// 搜索二叉树所有值为7的节点，并返回到这些节点的路径，并要求路径中不包含值为3的节点。
    /// </summary>
    /// <param name="root"></param>
    /// <param name="res"></param>
    /// <param name="path"></param>
    public void SearchNode(TreeNode<int>? root, List<List<TreeNode<int>>> res, List<TreeNode<int>> path)
    {
        // 剪枝
        if (root == null || root.Value == 3)
        {
            return;
        }
        // 尝试
        path.Add(root);
        if (root.Value == 7)
        {
            // 记录解
            res.Add([.. path]);
        }
        SearchNode(root.Left, res, path);
        SearchNode(root.Right, res, path);
        // 回退
        path.RemoveAt(path.Count - 1);
    }

    /// <summary>
    /// 回溯算法
    /// </summary>
    /// <param name="state"></param>
    /// <param name="choices"></param>
    /// <param name="res"></param>
    public void Backtrack(List<TreeNode<int>> state, List<TreeNode<int>> choices, List<List<TreeNode<int>>> res)
    {
        // 检查是否为解
        if (IsSolution(state))
        {
            // 记录解
            RecordSolution(state, res);
        }
        // 遍历所有选择
        foreach (var choice in choices)
        {
            if (!IsValid(state, choice))
            {
                continue;
            }
            // 尝试：做出选择，更新状态
            MakeChoice(state, choice);
            // 进行下一轮选择
            Backtrack(state, [choice.Left!, choice.Right!], res);
            // 回退：撤销选择，恢复到之前的状态
            UndoChoice(state, choice);
        }
    }

    /// <summary>
    /// 判断当前状态是否为解
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    protected virtual bool IsSolution(List<TreeNode<int>> state)
    {
        return state.Count != 0 && state[^1].Value == 7;
    }

    /// <summary>
    /// 记录解
    /// </summary>
    /// <param name="state"></param>
    /// <param name="res"></param>
    private void RecordSolution(List<TreeNode<int>> state, List<List<TreeNode<int>>> res)
    {
        res.Add([.. state]);
    }

    /// <summary>
    /// 判断在当前状态下，该选择是否合法
    /// </summary>
    /// <param name="state"></param>
    /// <param name="choice"></param>
    /// <returns></returns>
    private bool IsValid(List<TreeNode<int>> state, TreeNode<int>? choice)
    {
        return choice is not null && choice.Value != 3;
    }

    /// <summary>
    /// 更新状态
    /// </summary>
    /// <param name="state"></param>
    /// <param name="choice"></param>
    private void MakeChoice(List<TreeNode<int>> state, TreeNode<int> choice)
    {
        state.Add(choice);
    }

    /// <summary>
    /// 恢复状态
    /// </summary>
    /// <param name="state"></param>
    /// <param name="choice"></param>
    private void UndoChoice(List<TreeNode<int>> state, TreeNode<int> choice)
    {
        state.RemoveAt(state.Count - 1);
    }
}