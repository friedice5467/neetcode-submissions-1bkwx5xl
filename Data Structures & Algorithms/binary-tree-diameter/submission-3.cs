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
    private static int res = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        res = 0;
        DFS(root);
        return res;
    }

    public int DFS(TreeNode root)
    {
        if(root == null) return 0;

        var left = DFS(root.left);
        var right = DFS(root.right);
        res = Math.Max(res, left+right);
        return Math.Max(left, right) + 1;
    }
}
