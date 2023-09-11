//Example 1:

//Input: root = [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1], targetSum = 22
//Output: true
//Explanation: The root-to - leaf path with the target sum is shown.

//Example 2:

//Input: root = [1, 2, 3], targetSum = 5
//Output: false
//Explanation: There two root - to - leaf paths in the tree:
//(1-- > 2): The sum is 3.
//(1 --> 3): The sum is 4.
//There is no root-to-leaf path with sum = 5.

//Example 3:

//Input: root = [], targetSum = 0
//Output: false
//Explanation: Since the tree is empty, there are no root-to-leaf paths.

namespace _112PathSum
{
    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            if (root.left == null && root.right == null) return targetSum == root.val;

            bool leftSum = HasPathSum(root.left, targetSum - root.val);
            bool rightSum = HasPathSum(root.right, targetSum - root.val);

            return leftSum || rightSum;
        }
    }
}
