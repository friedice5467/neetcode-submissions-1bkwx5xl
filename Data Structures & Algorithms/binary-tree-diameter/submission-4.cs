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
    public int DiameterOfBinaryTree(TreeNode root) {
        var res = 0;
        FindDia(root,ref res);
        return res;
    }

    public int FindDia(TreeNode root, ref int res)
    {
        if(root == null) return 0;

        var left = FindDia(root.left, ref res);
        var right = FindDia(root.right, ref res);
        
        res = Math.Max(res, left + right);
        return Math.Max(left, right) + 1;
    }
}
