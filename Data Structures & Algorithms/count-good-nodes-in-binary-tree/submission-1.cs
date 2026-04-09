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
    public int GoodNodes(TreeNode root) {
        if(root == null) return 0;
        return DFS(root, root.val);
    }

    public int DFS(TreeNode root, int maxVal)
    {
        if(root == null) return 0;

        var res = root.val >= maxVal ? 1 : 0;
        maxVal = Math.Max(root.val, maxVal);
        res += DFS(root.left, maxVal);
        res += DFS(root.right, maxVal);
        return res;
    }
}
