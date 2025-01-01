namespace BinaryTreeInOrderTraversal
{
    public class Solution
    {
        /*
         * Pseudo Code:
         * 1) Create a list to store the result.
         * 2) Create a helper function that takes a TreeNode as an argument.
         * 3) If the TreeNode is not null, recursively call the helper function with the left child of the TreeNode.
         * 4) Add the value of the TreeNode to the result list.
         * 5) Recursively call the helper function with the right child of the TreeNode.
         * 6) Return the result list.
         */

        List<int> result = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            Helper(root);
            return result;
        }

        public void Helper(TreeNode root)
        {
            if (root != null)
            {
                Helper(root.left);
                result.Add(root.val);
                Helper(root.right);
            }
        }
    }
}
