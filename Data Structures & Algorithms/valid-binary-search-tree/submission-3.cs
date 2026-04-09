/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        return Valid(root, int.MinValue, int.MaxValue);
    }

    private bool Valid(TreeNode root, int left, int right)
    {
        if(root == null) return true;

        if(!(left < root.val && right > root.val))
            return false;

        return Valid(root.left, left, root.val) && Valid(root.right, root.val, right);
    }
}
