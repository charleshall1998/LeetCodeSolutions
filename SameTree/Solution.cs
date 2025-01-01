﻿namespace SameTree
{
    public class Solution
    {
        /* Pseudo Code:
         * 1) Base Case: If both trees are empty, they are identical.
         * 2) If one of the trees is empty and the other is not, they are not identical.
         * 3) If the values of the current nodes are different, the trees are not identical.
         * 4) Recursively check the left and right subtrees.
         */
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            // Base case: If both trees are empty, they are identical.
            if (p == null && q == null)
            {
                return true;
            }

            // If one of the trees is empty and the other is not, they are not identical.
            if (p == null || q == null)
            {
                return false;
            }

            // Compare the values of the current nodes.
            if (p.val != q.val)
            {
                return false;
            }

            // Recursively check the left and right subtrees.
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
