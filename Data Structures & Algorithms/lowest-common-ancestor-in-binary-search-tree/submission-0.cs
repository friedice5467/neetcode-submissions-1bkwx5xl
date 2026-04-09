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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null) return null;

        //if p and q are greater than parent, recursively find lca
        if(p.val > root.val && q.val > root.val)
            return LowestCommonAncestor(root.right, p, q);
        //if p and q are less than paretn, recursively find lca
        else if(p.val < root.val && q.val < root.val)
            return LowestCommonAncestor(root.left, p, q);
        else
            return root;

        //else if root is between p and q return current root
    }
}
