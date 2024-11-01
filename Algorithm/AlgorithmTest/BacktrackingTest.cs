using Algorithms.Backtracking;
using DataStructure;
using DataStructure.Tree;
using System.IO;
using Shouldly;

namespace AlgorithmTest;

public class BacktrackingTest
{
    [Fact]
    public void SearchNode_Test()
    {
        TreeNode<int> node = new(1)
        {
            Left = new TreeNode<int>(7)
            {
                Left = new TreeNode<int>(4),
                Right = new TreeNode<int>(5)
            },
            Right = new TreeNode<int>(3)
            {
                Left = new TreeNode<int>(6),
                Right = new TreeNode<int>(7)
            }
        };

        List<List<TreeNode<int>>> res = [];
        List<TreeNode<int>> path = [];
        new TreeSearch().SearchNode(node, res, path);
        res.Count.ShouldBe(1);
        res[0].Count.ShouldBe(2);
        res[0][0].Value.ShouldBe(1);
        res[0][1].Value.ShouldBe(7);
    }

    [Fact]
    public void Backtrack_Test()
    {
        TreeNode<int> node = new(1)
        {
            Left = new TreeNode<int>(7)
            {
                Left = new TreeNode<int>(4),
                Right = new TreeNode<int>(5)
            },
            Right = new TreeNode<int>(3)
            {
                Left = new TreeNode<int>(6),
                Right = new TreeNode<int>(7)
            }
        };

        List<List<TreeNode<int>>> res = [];
        new TreeSearch().Backtrack([], [node], res);
        res.Count.ShouldBe(1);
        res[0].Count.ShouldBe(2);
        res[0][0].Value.ShouldBe(1);
        res[0][1].Value.ShouldBe(7);
    }
}