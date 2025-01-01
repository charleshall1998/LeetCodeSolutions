using BinaryTreeInOrderTraversal;

/*
 * Problem Statement:
 * Given the `root` of a binary tree, return the inorder traversal of its nodes' values.
 */

var root = new TreeNode(1)
{
    right = new TreeNode(2)
    {
        left = new TreeNode(3)
    }
};

var solution = new Solution();

var result = solution.InorderTraversal(root);

Console.WriteLine($"[{string.Join(", ", result)}]"); // [1, 3, 2]
