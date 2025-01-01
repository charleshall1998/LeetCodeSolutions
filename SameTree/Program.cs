using SameTree;

/*
 * Problem Statement:
 * Given the roots of two binary trees `p` and `q`, write a function to check if they are the same or not.
 * Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
 */

var p = new TreeNode(1)
{
    left = new TreeNode(2),
    right = new TreeNode(3)
};

var q = new TreeNode(1)
{
    left = new TreeNode(2),
    right = new TreeNode(3)
};

var solution = new Solution();

Console.WriteLine(solution.IsSameTree(p, q)); // True