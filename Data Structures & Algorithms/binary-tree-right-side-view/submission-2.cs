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
    public List<int> RightSideView(TreeNode root) {
        var res = new List<int>();
        if(root == null) return res;

        var nodeQ = new Queue<TreeNode>();
        nodeQ.Enqueue(root);

        while(nodeQ.Count > 0)
        {
            var qLen = nodeQ.Count;
            for(int i = 0; i < qLen; i++)
            {
                var temp = nodeQ.Dequeue();

                if(i == qLen - 1)
                    res.Add(temp.val);

                if(temp.left != null)
                    nodeQ.Enqueue(temp.left);

                if(temp.right != null)
                    nodeQ.Enqueue(temp.right);
            }
        }
        return res;
    }
}
