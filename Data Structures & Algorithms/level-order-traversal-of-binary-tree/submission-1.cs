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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = new();
        if(root == null) return res;

        var nodeQ = new Queue<TreeNode>();
        nodeQ.Enqueue(root);
        while(nodeQ.Count > 0)
        {
            var level = nodeQ.Count;
            var nList = new List<int>();

            for(int i = 0; i < level; i++)
            {
                var temp = nodeQ.Dequeue();
                nList.Add(temp.val);

                if(temp.left != null)
                    nodeQ.Enqueue(temp.left);

                if(temp.right != null)
                    nodeQ.Enqueue(temp.right);
            }
            res.Add(nList);
        }

        return res;
    }
}
