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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(subRoot == null)
            return true;

        if(root == null)
            return false;

        if(IsSameTree(root, subRoot))
            return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool IsSameTree(TreeNode tree1, TreeNode tree2)
    {
        if(tree1 == null && tree2 == null)
            return true;
        else if(tree1 != null && tree2 != null && tree1.val == tree2.val)
            return IsSameTree(tree1.left, tree2.left) && IsSameTree(tree1.right, tree2.right);
        else
            return false;
    }
}
